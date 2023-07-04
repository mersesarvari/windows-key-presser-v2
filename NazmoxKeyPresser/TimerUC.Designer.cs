namespace NazmoxKeyPresser
{
    partial class TimerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label13 = new Label();
            label8 = new Label();
            label12 = new Label();
            numericUpDown1 = new NumericUpDown();
            TimerLabel = new Label();
            label11 = new Label();
            setTimeIntervallButton = new Button();
            label9 = new Label();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(112, 300);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 45;
            label13.Text = "label13";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 28);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 40;
            label8.Text = "Minimum time";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(55, 300);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 44;
            label12.Text = "Ticked:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Location = new Point(170, 26);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 26);
            numericUpDown1.TabIndex = 24;
            numericUpDown1.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Location = new Point(162, 248);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(58, 20);
            TimerLabel.TabIndex = 43;
            TimerLabel.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 248);
            label11.Name = "label11";
            label11.Size = new Size(102, 20);
            label11.TabIndex = 42;
            label11.Text = "Current Timer:";
            // 
            // setTimeIntervallButton
            // 
            setTimeIntervallButton.FlatStyle = FlatStyle.Flat;
            setTimeIntervallButton.Location = new Point(55, 186);
            setTimeIntervallButton.Margin = new Padding(3, 4, 3, 4);
            setTimeIntervallButton.Name = "setTimeIntervallButton";
            setTimeIntervallButton.Size = new Size(297, 29);
            setTimeIntervallButton.TabIndex = 28;
            setTimeIntervallButton.Text = "Set time interval";
            setTimeIntervallButton.UseVisualStyleBackColor = true;
            setTimeIntervallButton.Click += setTimeIntervallButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 113);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 41;
            label9.Text = "Maximum time";
            // 
            // numericUpDown2
            // 
            numericUpDown2.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown2.Location = new Point(170, 111);
            numericUpDown2.Margin = new Padding(3, 4, 3, 4);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 26);
            numericUpDown2.TabIndex = 36;
            numericUpDown2.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // TimerUC
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(numericUpDown1);
            Controls.Add(TimerLabel);
            Controls.Add(label11);
            Controls.Add(setTimeIntervallButton);
            Controls.Add(label9);
            Controls.Add(numericUpDown2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TimerUC";
            Size = new Size(838, 604);
            Load += TimerUC_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Label label8;
        private Label label12;
        private NumericUpDown numericUpDown1;
        private Label TimerLabel;
        private Label label11;
        private Button setTimeIntervallButton;
        private Label label2;
        private Label label9;
        private Label label5;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown5;
        private Label label6;
        private Label label7;
    }
}
