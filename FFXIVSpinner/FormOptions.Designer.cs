namespace FFXIVSpinner
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownJumpPercent = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumpPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Time (Seconds)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum Time (Seconds)";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 85);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(179, 85);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.DecimalPlaces = 1;
            this.numericUpDownMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMin.Location = new System.Drawing.Point(170, 7);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(84, 23);
            this.numericUpDownMin.TabIndex = 4;
            this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.DecimalPlaces = 1;
            this.numericUpDownMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMax.Location = new System.Drawing.Point(170, 31);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(84, 23);
            this.numericUpDownMax.TabIndex = 5;
            this.numericUpDownMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDownJumpPercent
            // 
            this.numericUpDownJumpPercent.Location = new System.Drawing.Point(170, 56);
            this.numericUpDownJumpPercent.Name = "numericUpDownJumpPercent";
            this.numericUpDownJumpPercent.Size = new System.Drawing.Size(84, 23);
            this.numericUpDownJumpPercent.TabIndex = 8;
            this.numericUpDownJumpPercent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Percent Chance to Jump";
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 123);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownJumpPercent);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumpPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownJumpPercent;
        private System.Windows.Forms.Label label3;
    }
}