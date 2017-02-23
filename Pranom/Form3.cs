using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pranom
{
    public partial class Form3 : Form
    {
        
        public string label3value
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }
        public string label4value
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }
        public Form3()
        {
            InitializeComponent();
        }
        Form1 F1 = new Form1();
        Form2 F2 = new Form2();
        Form4 F4 = new Form4();
        Form5 F5 = new Form5();
        Form6 F6 = new Form6();
        private void button2_Click(object sender, EventArgs e)
        {
            F2 = new Form2();
            F2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F4 = new Form4();
            F4.ShowDialog();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F5 = new Form5();
            F5.ShowDialog();
        }
        Timer t = new Timer();
        private void Form3_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToShortDateString();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start(); 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";
            if (hh < 10)
                time += "0" + hh;
            else
                time += hh;
            time += " : ";
            if (mm < 10)
                time += "0" + mm;
            else
                time += mm;
            time += " : ";
            if (ss < 10)
                time += "0" + ss;
            else
                time += ss;
            label1.Text = time;
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                F1.Show();
                this.Hide();
                F2.Close();
                F4.Close();
                F5.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit ?", "Confirm to Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 F8 = new Form8();
           F8.ShowDialog();
        }
        private void ChangePW_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 F10 = new Form10();
            F10.label6value = label3value;
            F10.label7value = label4value;
            F10.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form11 F11 = new Form11();
            F11.ShowDialog();
        }
    }
}
