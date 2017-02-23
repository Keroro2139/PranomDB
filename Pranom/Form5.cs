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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string Gender;
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you want to clear all this data?", "Clear", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                textBox2.Text = "000";
                textBox2.ForeColor = Color.LightGray;
                textBox3.Text = "Name";
                textBox3.ForeColor = Color.LightGray;
                textBox4.Text = "Surname";
                textBox4.ForeColor = Color.LightGray;
                comboBox1.Text = "Male/Female";
                comboBox1.ForeColor = Color.LightGray;
                textBox7.Text = "0000000000";
                textBox7.ForeColor = Color.LightGray;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool c = true, k = true;
            if (textBox2.Text == "000" || textBox3.Text == "Name" || textBox4.Text == "Surname" || textBox7.Text == "0000000000" || comboBox1.Text == "Male/Female")
            {
                k = false;
                MessageBox.Show("Please, input all data.");
            }
            if (k)
            {
                string sql = "SELECT * FROM MEMBER";
                sql = "INSERT INTO MEMBER (MEM_CODE,MEM_FNAME,MEM_LNAME,MEM_SEX,MEM_TEL) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "')";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception exam)
                {
                    c = false;
                    MessageBox.Show("This code is already.");
                }
                if (c)
                    MessageBox.Show("Add employee complete!");
                textBox2.Text = "000";
                textBox2.ForeColor = Color.LightGray;
                textBox3.Text = "Name";
                textBox3.ForeColor = Color.LightGray;
                textBox4.Text = "Surname";
                textBox4.ForeColor = Color.LightGray;
                comboBox1.Text = "Male/Female";
                comboBox1.ForeColor = Color.LightGray;
                textBox7.Text = "0000000000";
                textBox7.ForeColor = Color.LightGray;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "000")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "000";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Name")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Name";
                textBox3.ForeColor = Color.LightGray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Surname")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Surname";
                textBox4.ForeColor = Color.LightGray;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "0000000000")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "0000000000";
                textBox7.ForeColor = Color.LightGray;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Male/Female")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Male/Female";
                comboBox1.ForeColor = Color.LightGray;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Can't enter with manual");
            comboBox1.Text = "Male/Female";
            comboBox1.ForeColor = Color.LightGray;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
        }




        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "000")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "000";
                textBox5.ForeColor = Color.LightGray;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Name")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Name";
                textBox9.ForeColor = Color.LightGray;
            }
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "Surname")
            {
                textBox11.Text = "";
                textBox11.ForeColor = Color.Black;
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "Surname";
                textBox11.ForeColor = Color.LightGray;
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you want to clear all this data?", "Clear", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                textBox5.Text = "000";
                textBox5.ForeColor = Color.LightGray;
                textBox9.Text = "Name";
                textBox9.ForeColor = Color.LightGray;
                textBox11.Text = "Surname";
                textBox11.ForeColor = Color.LightGray;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool c = false, go = true;
            string sql = "SELECT * FROM MEMBER WHERE MEM_CODE = '" + textBox5.Text + "'";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                c = true;
                DialogResult dl = MessageBox.Show("Do you want to remove? " + System.Environment.NewLine + "Member ID: " + textBox5.Text + System.Environment.NewLine + "Name: " + reader.GetString("MEM_FNAME") + " " + reader.GetString("MEM_LNAME") + "", "Remove", MessageBoxButtons.YesNo);
                if (dl == DialogResult.Yes)
                    go = true;
                else
                    go = false;
            }
            con.Close();
            if (go)
            {
                sql = "DELETE FROM MEMBER WHERE MEM_CODE = '" + textBox5.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                if (c)
                    MessageBox.Show("remove success.");
                else
                    MessageBox.Show("This person is not in list.");
                con.Close();
            }

        }

        //-----------------------------------------------------------------------------------------------------------------//

        private void button8_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM MEMBER";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                string code = reader.GetString("MEM_CODE");
                string name = reader.GetString("MEM_FNAME");
                string surname = reader.GetString("MEM_LNAME");
                string sex = reader.GetString("MEM_SEX");
                string hiredate = reader.GetString("MEM_TIMESTAMP");
                string tel = reader.GetString("MEM_TEL");

                dataGridView1.Rows.Add(code, name, surname, sex, hiredate);
            }
            con.Close();
        }


        //--------------------------------------------------------------------------------------------------------------//

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Name Surname")
            {
                string a = textBox1.Text;
                string[] b = a.Split(' ');
                string sql = "SELECT * FROM MEMBER WHERE MEM_FNAME = '" + b[0] + "' AND MEM_LNAME ='" + b[1] + "'  ";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("MEM_CODE");
                    string name = reader.GetString("MEM_FNAME");
                    string surname = reader.GetString("MEM_LNAME");
                    string sex = reader.GetString("MEM_SEX");
                    string hiredate = reader.GetString("MEM_TIMESTAMP");
                    string tel = reader.GetString("MEM_TEL");
                    dataGridView1.Rows.Add(code, name, surname, sex, hiredate, tel);
                }
                con.Close();
            }
            else if (comboBox3.Text == "Name")
            {
                string sql = "SELECT * FROM MEMBER WHERE MEM_FNAME = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("MEM_CODE");
                    string name = reader.GetString("MEM_FNAME");
                    string surname = reader.GetString("MEM_LNAME");
                    string sex = reader.GetString("MEM_SEX");
                    string hiredate = reader.GetString("MEM_TIMESTAMP");
                    string tel = reader.GetString("MEM_TEL");
                    dataGridView1.Rows.Add(code, name, surname, sex, hiredate, tel);
                }
                con.Close();
            }
            else if (comboBox3.Text == "Surname")
            {
                string sql = "SELECT * FROM MEMBER WHERE MEM_LNAME = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("MEM_CODE");
                    string name = reader.GetString("MEM_FNAME");
                    string surname = reader.GetString("MEM_LNAME");
                    string sex = reader.GetString("MEM_SEX");
                    string hiredate = reader.GetString("MEM_TIMESTAMP");
                    string tel = reader.GetString("MEM_TEL");
                    dataGridView1.Rows.Add(code, name, surname, sex, hiredate, tel);
                }
                con.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Code" && textBox1.Text.Length == 3)
            {
                string sql = "SELECT * FROM MEMBER WHERE MEM_CODE = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("MEM_CODE");
                    string name = reader.GetString("MEM_FNAME");
                    string surname = reader.GetString("MEM_LNAME");
                    string sex = reader.GetString("MEM_SEX");
                    string hiredate = reader.GetString("MEM_TIMESTAMP");
                    string tel = reader.GetString("MEM_TEL");

                    dataGridView1.Rows.Add(code, name, surname, sex, hiredate, tel);
                }
                con.Close();
            }
        }


        //------------------------------------------------------------------------------------------------------------------//

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox12.Text.Length == 3)
            {
                bool ch = false;
                string sql = "SELECT * FROM MEMBER WHERE MEM_CODE = '" + textBox12.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ch = true;
                    textBox13.Text = reader.GetString("MEM_FNAME");
                    textBox14.Text = reader.GetString("MEM_LNAME");
                    textBox15.Text = reader.GetString("MEM_SEX");
                    textBox16.Text = reader.GetString("MEM_TEL");
                  
                }
                con.Close();
                if (!ch)
                    MessageBox.Show("This person is not in list.");
            }
            else
            {
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM MEMBER WHERE MEM_CODE = '" + textBox12.Text + "'";
            sql = "UPDATE MEMBER SET MEM_FNAME = '" + textBox13.Text + "',MEM_LNAME = '" + textBox14.Text + "',MEM_SEX = '" + textBox15.Text + "',MEM_TEL = '" + textBox16.Text + "' WHERE MEM_CODE = '" + textBox12.Text + "'";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult dl = MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                MessageBox.Show("Updated success.");
            }
        }

    }
}
