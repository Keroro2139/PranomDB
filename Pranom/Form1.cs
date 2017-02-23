using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string user = "", sta = "";
        public string u
        {
            get { return user; }
            set { user = value; }
        }
        public string s
        {
            get { return sta; }
            set { sta = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LOGIN WHERE Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";
            MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            bool ch = true;
            while (reader.Read())
            {
                string session_sql = reader.GetString("Status");
                string use = reader.GetString("Username");
                if (session_sql == "ADMIN")
                {
                    user = use;
                    sta = session_sql;
                    Form3 admin_page = new Form3();
                    admin_page.label3value = user;
                    admin_page.label4value = sta;
                    admin_page.Show();
                    this.Hide();
                    ch = false;
                }
                else if (session_sql == "USER")
                {
                    Form9 user_page = new Form9();
                    user_page.Show();
                    this.Hide();
                    ch = false;
                }
            }
            if (ch)
            {
                DialogResult dl = MessageBox.Show("Username or Password is wrong.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            con.Close();
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you want to exit?","Login", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "User ID")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Red;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "User ID";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Red;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
        
    }
}
