using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NazmoxKeyPresser
{
    public partial class KeysUC : UserControl
    {

        //public static KeysUC Instance;
        public KeysUC()
        {
            InitializeComponent();

        }

        private void KeysUC_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in Form1.config.Keys)
            {
                listBox1.Items.Add(item);
            }
            if (listBox1.Items.Count == 0)
            {
                listBox1.SelectedIndex = -1;
            }
            else
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //Adding Delete Keys
            if (e.KeyCode.ToString().ToLower() == "delete" || e.KeyCode.ToString().ToLower() == "back")
                RemoveKey();
            else
            {
                listBox1.Items.Add(e.KeyCode.ToString().Trim());
                Form1.config.Keys.Add(e.KeyCode);
                var counter = listBox1.Items.Count;
            }
        }

        public void RemoveKey()
        {
            Form1.config.Keys.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void removeKeyButton_Click(object sender, EventArgs e)
        {
            RemoveKey();
        }

    }
}
