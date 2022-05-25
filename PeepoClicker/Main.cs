using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeepoClicker
{
    public partial class Main : Form
    {
        utils.Hook hook;
        Point Pos;
        bool mDown = false;

        #region dlls
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration
        #endregion 

        public Main()
        {
            InitializeComponent();
        }

        private void panelWindowTitle_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panelWindowTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panelWindowTitle_MouseDown_1(object sender, MouseEventArgs e)
        {
            Pos.X = e.X;
            Pos.Y = e.Y;
            mDown = true;
        }

        private void panelWindowTitle_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelWindowTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mDown)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - Pos.X, currentPos.Y - Pos.Y);
            }

        }

        private void panelWindowTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void sliderCPS_Scroll(object sender, ScrollEventArgs e)
        {
            lbCPS.Text = "LMB CPS: " + $"{sliderCPS.Value}";
        }

        private void LeftClicker_Tick(object sender, EventArgs e)
        {
            LeftClicker.Interval = 1000 / randomizedCPS;

            // Find minecraft process
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {   
                    if (enabledBox.Checked)
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                            Task.Delay(20).Wait();
                            SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                        }
                    }
                }
            }
        }

        int randomizedCPS = 10;
        private void Random_Tick(object sender, EventArgs e)
        {
            randomizedCPS = new Random().Next(sliderCPS.Value - 3, sliderCPS.Value + 3);
        }

        private void rightCPS_Scroll(object sender, ScrollEventArgs e)
        {
            rbCPS.Text = "RMB CPS: " + $"{sliderCPS.Value}";
        }

        private void RightClicker_Tick(object sender, EventArgs e)
        {

        }
    }
}
