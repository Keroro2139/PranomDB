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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {
        }

        private void Code_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Change.PerformClick();
            }
        }
        private void Change_Click(object sender, EventArgs e)
        {
            if (OldPW.Text.Length == 0 && NewPW1.Text.Length == 0 && NewPW2.Text.Length == 0 || NewPW1.Text == "Password" && NewPW1.ForeColor == Color.LightGray || NewPW2.Text == "Password" && NewPW2.ForeColor == Color.LightGray)
            {
                DialogResult dl = MessageBox.Show("Please input a data.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool hum = true;
                if (hum)
                {
                    bool ch = false;
                    string sql = "SELECT * FROM LOGIN WHERE Username = '" + label6.Text + "' AND Password = '" + OldPW.Text + "'";
                    MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ch = true;
                    }
                    con.Close();
                    if (ch == false)
                    {
                        hum = false;
                        DialogResult dl = MessageBox.Show("Your old password not correct.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (NewPW1.Text != NewPW2.Text)
                    {
                        hum = false;
                        DialogResult dl = MessageBox.Show("Your new password is not match.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (hum)
                {
                    if (OldPW.Text.Length == 0 || NewPW1.Text.Length == 0 || NewPW2.Text.Length == 0)
                    {
                        DialogResult dl = MessageBox.Show("Please input a Code.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string sql = "UPDATE LOGIN SET Password = '" + NewPW1.Text + "' WHERE Username = '" + label6.Text + "'";
                        MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        DialogResult dl = MessageBox.Show("Do you want to change password?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dl == DialogResult.Yes)
                        {
                            DialogResult d = MessageBox.Show("Success", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form3 F3 = new Form3();
                            F3.Hide();
                            Form1 F1 = new Form1();
                            F1.Show();
                            OldPW.Text = "";
                            NewPW1.Text = "";
                            NewPW2.Text = "";
                        }
                        con.Close();

                    }
                }
            }
        }

        

        private void OldPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Change.PerformClick();
            }
        }

        private void NewPW1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Change.PerformClick();
            }
        }

        private void NewPW2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Change.PerformClick();
            }
        }

        private void OldPW_Enter(object sender, EventArgs e)
        {
            if (OldPW.Text == "Password")
            {
                OldPW.Text = "";
                OldPW.ForeColor = Color.Black;
            }
        }

        private void OldPW_Leave(object sender, EventArgs e)
        {
            if (OldPW.Text == "")
            {
                OldPW.Text = "Password";
                OldPW.ForeColor = Color.LightGray;
            }
        }

        private void NewPW1_Enter(object sender, EventArgs e)
        {
            if (NewPW1.Text == "Password")
            {
                NewPW1.Text = "";
                NewPW1.ForeColor = Color.Black;
            }
        }

        private void NewPW1_Leave(object sender, EventArgs e)
        {
            if (NewPW1.Text == "")
            {
                NewPW1.Text = "Password";
                NewPW1.ForeColor = Color.LightGray;
            }
        }

        private void NewPW2_Enter(object sender, EventArgs e)
        {
            if (NewPW2.Text == "Password")
            {
                NewPW2.Text = "";
                NewPW2.ForeColor = Color.Black;
            }
        }

        private void NewPW2_Leave(object sender, EventArgs e)
        {
            if (NewPW2.Text == "")
            {
                NewPW2.Text = "Password";
                NewPW2.ForeColor = Color.LightGray;
            }
        }
        public string label6value
        {
            get { return label6.Text; }
            set { label6.Text = value; }
        }
        public string label7value
        {
            get { return label7.Text; }
            set { label7.Text = value; }
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.label3value = label6.Text;
            F3.label4value = label7.Text;
        }
    }
}
