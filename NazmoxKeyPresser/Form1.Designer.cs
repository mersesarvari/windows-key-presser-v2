namespace NazmoxKeyPresser
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            panel1 = new Panel();
            panelNav = new Panel();
            button7 = new Button();
            BtnSettings = new Button();
            BtnTimer = new Button();
            BtnKeys = new Button();
            BtnDashboard = new Button();
            panel2 = new Panel();
            label15 = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            button2 = new Button();
            PanelFormLoader = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(553, 15);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(159, 51);
            button1.TabIndex = 8;
            button1.Text = "Save Settings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(panelNav);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(BtnSettings);
            panel1.Controls.Add(BtnTimer);
            panel1.Controls.Add(BtnKeys);
            panel1.Controls.Add(BtnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 706);
            panel1.TabIndex = 9;
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(0, 126, 249);
            panelNav.Location = new Point(0, 244);
            panelNav.Margin = new Padding(3, 4, 3, 4);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(3, 127);
            panelNav.TabIndex = 5;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(0, 126, 249);
            button7.Location = new Point(0, 652);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(213, 53);
            button7.TabIndex = 4;
            button7.Text = "Dashboard";
            button7.TextImageRelation = TextImageRelation.TextBeforeImage;
            button7.UseVisualStyleBackColor = true;
            // 
            // BtnSettings
            // 
            BtnSettings.Dock = DockStyle.Top;
            BtnSettings.FlatAppearance.BorderSize = 0;
            BtnSettings.FlatStyle = FlatStyle.Flat;
            BtnSettings.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            BtnSettings.Location = new Point(0, 341);
            BtnSettings.Margin = new Padding(3, 4, 3, 4);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(213, 53);
            BtnSettings.TabIndex = 1;
            BtnSettings.Text = "Settings";
            BtnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnSettings.UseVisualStyleBackColor = true;
            BtnSettings.Click += BtnSettings_Click;
            BtnSettings.Leave += BtnSettings_Leave;
            // 
            // BtnTimer
            // 
            BtnTimer.Dock = DockStyle.Top;
            BtnTimer.FlatAppearance.BorderSize = 0;
            BtnTimer.FlatStyle = FlatStyle.Flat;
            BtnTimer.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTimer.ForeColor = Color.FromArgb(0, 126, 249);
            BtnTimer.Location = new Point(0, 288);
            BtnTimer.Margin = new Padding(3, 4, 3, 4);
            BtnTimer.Name = "BtnTimer";
            BtnTimer.Size = new Size(213, 53);
            BtnTimer.TabIndex = 1;
            BtnTimer.Text = "Timers";
            BtnTimer.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnTimer.UseVisualStyleBackColor = true;
            BtnTimer.Click += BtnTimer_Click;
            BtnTimer.Leave += BtnTimer_Leave;
            // 
            // BtnKeys
            // 
            BtnKeys.Dock = DockStyle.Top;
            BtnKeys.FlatAppearance.BorderSize = 0;
            BtnKeys.FlatStyle = FlatStyle.Flat;
            BtnKeys.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKeys.ForeColor = Color.FromArgb(0, 126, 249);
            BtnKeys.Location = new Point(0, 235);
            BtnKeys.Margin = new Padding(3, 4, 3, 4);
            BtnKeys.Name = "BtnKeys";
            BtnKeys.Size = new Size(213, 53);
            BtnKeys.TabIndex = 1;
            BtnKeys.Text = "Keys to Press";
            BtnKeys.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnKeys.UseVisualStyleBackColor = true;
            BtnKeys.Click += BtnKeys_Click;
            BtnKeys.Leave += BtnKeys_Leave;
            // 
            // BtnDashboard
            // 
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            BtnDashboard.Location = new Point(0, 182);
            BtnDashboard.Margin = new Padding(3, 4, 3, 4);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(213, 53);
            BtnDashboard.TabIndex = 1;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnDashboard.UseVisualStyleBackColor = true;
            BtnDashboard.Click += BtnDashboard_Click;
            BtnDashboard.Enter += BtnDashboard_Enter;
            BtnDashboard.Leave += BtnDashboard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(213, 182);
            panel2.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(158, 161, 176);
            label15.Location = new Point(69, 132);
            label15.Name = "label15";
            label15.Size = new Size(68, 17);
            label15.TabIndex = 2;
            label15.Text = "Version:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 126, 149);
            label14.Location = new Point(55, 111);
            label14.Name = "label14";
            label14.Size = new Size(98, 20);
            label14.TabIndex = 1;
            label14.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(158, 161, 176);
            labelTitle.Location = new Point(239, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(193, 39);
            labelTitle.TabIndex = 10;
            labelTitle.Text = "Dashboard";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(944, 24);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(29, 32);
            button2.TabIndex = 11;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            // 
            // PanelFormLoader
            // 
            PanelFormLoader.Dock = DockStyle.Bottom;
            PanelFormLoader.Location = new Point(213, 102);
            PanelFormLoader.Margin = new Padding(3, 4, 3, 4);
            PanelFormLoader.Name = "PanelFormLoader";
            PanelFormLoader.Size = new Size(874, 604);
            PanelFormLoader.TabIndex = 12;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Location = new Point(718, 12);
            button3.Name = "button3";
            button3.Size = new Size(171, 60);
            button3.TabIndex = 9;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1087, 706);
            Controls.Add(button3);
            Controls.Add(PanelFormLoader);
            Controls.Add(button2);
            Controls.Add(labelTitle);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Clicker";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Label label15;
        private Label label14;
        private PictureBox pictureBox1;
        private Panel panelNav;
        private Button button7;
        private Button BtnSettings;
        private Button BtnTimer;
        private Button BtnKeys;
        private Button BtnDashboard;
        private Label labelTitle;
        private Button button2;
        private Panel PanelFormLoader;
        public System.Windows.Forms.Timer timer1;
        private Button button3;
    }
}