namespace NazmoxKeyPresser
{
    partial class KeysUC
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
            removeKeyButton = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // removeKeyButton
            // 
            removeKeyButton.FlatStyle = FlatStyle.Flat;
            removeKeyButton.Location = new Point(17, 448);
            removeKeyButton.Margin = new Padding(3, 4, 3, 4);
            removeKeyButton.Name = "removeKeyButton";
            removeKeyButton.Size = new Size(249, 29);
            removeKeyButton.TabIndex = 7;
            removeKeyButton.Text = "Remove Key";
            removeKeyButton.UseVisualStyleBackColor = true;
            removeKeyButton.Click += removeKeyButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 404);
            label1.Name = "label1";
            label1.Size = new Size(214, 20);
            label1.TabIndex = 6;
            label1.Text = "Press any Key on the list to add";
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Location = new Point(17, 56);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(249, 352);
            listBox1.TabIndex = 5;
            listBox1.KeyUp += listBox1_KeyUp;
            // 
            // KeysUC
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(removeKeyButton);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KeysUC";
            Size = new Size(838, 604);
            Load += KeysUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button removeKeyButton;
        private Label label1;
        private ListBox listBox1;
    }
}
