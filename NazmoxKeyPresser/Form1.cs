using System.Configuration;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;

namespace NazmoxKeyPresser
{

    public partial class Form1 : Form
    {
        public static bool status = false;
        public static Form1 Instance;
        public static Config config = new Config();
        public Form1 currentform { get; set; }
        Random randomGenerator = new Random();
        // Creating Forms
        DashboardUC formDashboard = new DashboardUC() { Dock = DockStyle.Fill };
        KeysUC formKeys = new KeysUC() { Dock = DockStyle.Fill };
        TimerUC formTimer = new TimerUC() { Dock = DockStyle.Fill };

        public void SetTimerInterval(int interval)
        {
            this.timer1.Interval = interval;
        }
        public Form1()
        {
            InitializeComponent();
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            Instance = this;
            if (File.Exists("config.json"))
            {
                config = config.LoadConfig();
                var c = config;
                ;
            }
            else
            {
                config.CreateBasicConfig();
            }
            currentform = this;
            //Set Menu active
            panelNav.Height = BtnDashboard.Height;
            panelNav.Top = BtnDashboard.Top;
            panelNav.Left = BtnDashboard.Left;



            //LoadDefaultForm
            labelTitle.Text = "Dashboard";
            this.PanelFormLoader.Controls.Clear();
            //FormDashboard formDashboard = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //formDashboard.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(formDashboard);
            formDashboard.Show();
        }

        private void setTimeIntervallButton_Click(object sender, EventArgs e)
        {
            formTimer.CheckTickIntervalValue(timer1);
            MessageBox.Show($"SetTimer clicked MinValue: {KeyPresser.MinTime}, MaxValue: {KeyPresser.MaxTime}");


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (status == true)
            {
                PressKey();
                KeyPresser.TickCounter++;
                //label13.Text = KeyPresser.TickCounter.ToString() + ". times";
                //Újrakalibrálás:
                timer1.Stop();
                formTimer.CheckTickIntervalValue(timer1);
                timer1.Start();
            }

        }
        public void PressKey()
        {
            [DllImport("User32.dll")]
            static extern int SetForegroundWindow(IntPtr point);
            //Getting world of warcraft application
            Process[] processes = Process.GetProcessesByName("wow");
            if (processes.Length <= 0)
            {
                MessageBox.Show("World of Warcraft is not running");
                timer1.Stop();
                //label10.Text = "Status: Not Running";
            }
            //World of warcraft is running
            else
            {
                var worldofwarcraftProcess = processes.FirstOrDefault();
                if (worldofwarcraftProcess != null)
                {
                    foreach (var item in config.Keys)
                    {
                        IntPtr h = worldofwarcraftProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        var sleeptimer = randomGenerator.Next(150, 300);
                        Thread.Sleep(sleeptimer);
                        //Setting wow to focus
                        SetForegroundWindow(h);
                        //SendKeys.SendWait("{"+item+"}");
                        InputSimulator isim = new InputSimulator();
                        //Beállítani a keyeket



                        isim.Keyboard.KeyDown((WindowsInput.Native.VirtualKeyCode)item);
                        //Random timer for the key down slppe
                        var randomSleep = randomGenerator.Next(15, 35);
                        Thread.Sleep(randomSleep);
                        //Releasing key
                        //isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.ESCAPE);
                        isim.Keyboard.KeyUp((WindowsInput.Native.VirtualKeyCode)item);
                    }

                }
            }
        }

        //Save Settings
        private void button1_Click(object sender, EventArgs e)
        {
            formTimer.CheckTickIntervalValue(timer1);
            config.Save(config.Keys, KeyPresser.MinTime, KeyPresser.MaxTime);
        }
        //Adding a character


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            panelNav.Height = BtnDashboard.Height;
            panelNav.Top = BtnDashboard.Top;
            panelNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Dashboard";
            this.PanelFormLoader.Controls.Clear();

            //formDashboard.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(formDashboard);
            formDashboard.Show();

        }

        private void BtnKeys_Click(object sender, EventArgs e)
        {
            panelNav.Height = BtnKeys.Height;
            panelNav.Top = BtnKeys.Top;
            panelNav.Left = BtnKeys.Left;
            BtnKeys.BackColor = Color.FromArgb(46, 51, 73);
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            labelTitle.Text = "Timers";
            this.PanelFormLoader.Controls.Clear();

            //formKeys.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(formKeys);
            formKeys.Show();
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {
            panelNav.Height = BtnTimer.Height;
            panelNav.Top = BtnTimer.Top;
            panelNav.Left = BtnTimer.Left;
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            BtnTimer.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Timers";
            this.PanelFormLoader.Controls.Clear();

            //formTimer.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(formTimer);
            formTimer.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            panelNav.Height = BtnSettings.Height;
            panelNav.Top = BtnSettings.Top;
            panelNav.Left = BtnSettings.Left;
            BtnSettings.BackColor = Color.FromArgb(46, 51, 73);
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            labelTitle.Text = "Settings";
            this.PanelFormLoader.Controls.Clear();
            /*
            FormTimer formTimer = new FormTimer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTimer.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(formTimer);
            formTimer.Show();
            */
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnKeys_Leave(object sender, EventArgs e)
        {
            BtnKeys.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnTimer_Leave(object sender, EventArgs e)
        {
            BtnTimer.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnDashboard_Enter(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Active
            if (status)
            {
                button3.BackColor = Color.Green;
                button3.Text = "Start";
                timer1.Stop();
                status = false;
            }
            //Inactive
            else
            {
                button3.BackColor = Color.Red;
                button3.Text = "Stop";
                formTimer.CheckTickIntervalValue(timer1);
                timer1.Start();
                KeyPresser.TickCounter = 0;
                status = true;
            }
        }
    }
}