using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
namespace Black_Ops_Hack
{
    public partial class Form1 : Form
    {
        Mem meme = new Mem();
        Mem Hack = new Mem();
        string aspAddress = "BlackOps.exe+0x1808F10";
        string m16multipleAddress = "BlackOps.exe+0x1808F00";
        string HealthAddress = "BlackOps.exe+0x167987C";
        string twoclip = "BlackOps.exe+0x1808E88";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = meme.GetProcIdFromName("BlackOps");
            int PID1 = Hack.GetProcIdFromName("Black Ops Hack");
            if (PID > 0)
            {
                MessageBox.Show("Process found "+PID);
                meme.OpenProcess(PID);
                label2.Text = "Working";
                label2.ForeColor = Color.Green;
                label3.Text = ("Hack PID "+PID1);
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Process not found "+PID);
                label3.Text = ("Hack PID " + PID1);
                label2.Text = "Not Working";
                label2.ForeColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
             {
                meme.WriteMemory(aspAddress, "int", "99");
                meme.WriteMemory(m16multipleAddress, "int", "99");
                meme.WriteMemory(twoclip, "int", "999");
            }
            if(checkBox2.Checked)
            {
                meme.WriteMemory(HealthAddress, "int", "99999");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool vai = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (vai == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            vai = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
