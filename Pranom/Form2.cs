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
using System.Data.SqlClient;

namespace Pranom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        add_day_off add = new add_day_off();

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
                textBox8.Text = "Your address";
                textBox8.ForeColor = Color.LightGray;
                comboBox2.Text = "P/F";
                comboBox2.ForeColor = Color.LightGray;
                textBox22.Text = "Position";
                textBox22.ForeColor = Color.LightGray;
                textBox10.Text = "0";
                textBox10.ForeColor = Color.LightGray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool c = true, k = true, p = true;
            if (textBox22.Text == "Position" || textBox2.Text=="000" || textBox3.Text=="Name" || textBox4.Text == "Surname" || textBox7.Text == "0000000000" || textBox8.Text == "Your address" || textBox10.Text == "0" || comboBox1.Text == "Male/Female" || comboBox2.Text == "P/F")
            {
                k = false;
                DialogResult dl = MessageBox.Show("Please, input all data.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(textBox2.Text.Length != 3)
            {
                p = false;
                DialogResult dl = MessageBox.Show("Please, input code 3 number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (k && p)
            {
                string sql = "SELECT * FROM EMPLOYEE";           
                sql = "INSERT INTO EMPLOYEE (EMP_CODE,EMP_FNAME,EMP_LNAME,EMP_SEX,EMP_HIREDATE,EMP_TEL,EMP_ADDRESS,EMP_TYPE,EMP_STATUS,BRAN_CODE) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "',NOW(),'" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox2.Text + "','" + textBox22.Text + "','" + textBox10.Text + "')";
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
                    MessageBox.Show("This code or name is already.");
                }
                if (c)
                {
                    string sql_create_login = "INSERT INTO LOGIN (UserID,Username,Password,Name,Status) VALUE('" + textBox2.Text + "','" + textBox2.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' '" + " " + "' '" + textBox4.Text + "','USER')";
                    con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                    MySqlCommand cmd_create_login = new MySqlCommand(sql_create_login, con);
                    con.Open();
                    cmd_create_login.ExecuteNonQuery();
                    MessageBox.Show("Add employee complete!");
                    con.Close();
                    if (comboBox2.Text == "F")
                    {
                        string intoSL = "INSERT INTO SALARY (EMP_CODE,F_CHG_HOUR) VALUE('" + textBox2.Text + "',76)";
                        MySqlConnection conSL = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                        MySqlCommand cmSL = new MySqlCommand(intoSL, conSL);
                        conSL.Open();
                        cmSL.ExecuteNonQuery();
                        conSL.Close();
                    }
                    else if (comboBox2.Text == "P")
                    {
                        string intoSL = "INSERT INTO SALARY (EMP_CODE,F_CHG_HOUR) VALUE('" + textBox2.Text + "',60)";
                        MySqlConnection conSL = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                        MySqlCommand cmSL = new MySqlCommand(intoSL, conSL);
                        conSL.Open();
                        cmSL.ExecuteNonQuery();
                        conSL.Close();
                    }
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
                    textBox8.Text = "Your address";
                    textBox8.ForeColor = Color.LightGray;
                    comboBox2.Text = "P/F";
                    comboBox2.ForeColor = Color.LightGray;
                    textBox22.Text = "Position";
                    textBox22.ForeColor = Color.LightGray;
                    textBox10.Text = "0";
                    textBox10.ForeColor = Color.LightGray;
                }
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text == "000")
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

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Your address")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Your address";
                textBox8.ForeColor = Color.LightGray;
            }
        }


        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "0")
            {
                textBox10.Text = "";
                textBox10.ForeColor = Color.Black;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "0";
                textBox10.ForeColor = Color.LightGray;
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Male/Female")
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

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            if(comboBox2.Text == "P/F")
            {
                comboBox2.Text = "";
                comboBox2.ForeColor = Color.Black;
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.Text = "P/F";
                comboBox2.ForeColor = Color.LightGray;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Can't enter with manual");
            comboBox1.Text = "";
            comboBox1.ForeColor = Color.Black;
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Can't enter with manual");
            comboBox2.Text = "";
            comboBox2.ForeColor = Color.Black;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.ForeColor = Color.Black;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            bool hum = true;
            if (hum)
            {
                bool ch = false;
                string sql = "SELECT * FROM EMPLOYEE WHERE EMP_CODE = '" + textBox5.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ch = true;
                }
                con.Close();
                if (!ch)
                {
                    hum = false;
                    DialogResult dl = MessageBox.Show("This person is not in list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (hum)
            {
                if (textBox5.Text.Length == 0 || textBox9.Text.Length == 0 || textBox11.Text.Length == 0)
                {
                    DialogResult dl = MessageBox.Show("Please input a Code.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dl = MessageBox.Show("Do you want to remove" + System.Environment.NewLine + "Code : " + textBox5.Text + System.Environment.NewLine + "Name : " + textBox9.Text + "  " + textBox11.Text, "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        string sql = "DELETE FROM EMPLOYEE WHERE EMP_CODE = '" + textBox5.Text + "'";
                        string sql2 = "DELETE FROM LOGIN WHERE Username = '" + textBox5.Text + "'";
                        string bor = "DELETE FROM BORROW_EMPLOYEE WHERE EMP_CODE = '" + textBox5.Text + "'";
                        string holi = "DELETE FROM HOLIDAY_DETAIL WHERE EMP_CODE = '" + textBox5.Text + "'";
                        string timework = "DELETE FROM TIMEWORK WHERE EMP_CODE = '" + textBox5.Text + "'";
                        string totaltime = "DELETE FROM EMPLOYEE_WORKTIME WHERE EMP_CODE = '" + textBox5.Text + "'";
                        MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                        MySqlCommand cmd3 = new MySqlCommand(bor, con);
                        MySqlCommand cmd4 = new MySqlCommand(holi, con);
                        MySqlCommand cmd5 = new MySqlCommand(timework, con);
                        MySqlCommand cmd6 = new MySqlCommand(totaltime, con);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        cmd4.ExecuteNonQuery();
                        cmd5.ExecuteNonQuery();
                        cmd6.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("remove success.");
                        textBox5.Text = "";
                        textBox9.Text = "";
                        textBox11.Text = "";
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
            bool k = true;
            if (textBox5.Text != "")
            {
                int number;
                if (!Int32.TryParse(textBox5.Text, out number))
                {
                    k = false;
                    MessageBox.Show("Please input only digit.", "Check your code.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Focus();
                    textBox5.BackColor = Color.IndianRed;
                }
            }
            if (textBox5.Text.Length == 3 && k)
            {
                bool ch = false;
                string sql = "SELECT * FROM EMPLOYEE WHERE EMP_CODE = '" + textBox5.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ch = true;
                    textBox9.Text = reader.GetString("EMP_FNAME");
                    textBox11.Text = reader.GetString("EMP_LNAME");
                }
                con.Close();
                if (!ch)
                {
                    DialogResult dl = MessageBox.Show("This person is not in list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textBox9.Text = "";
                textBox11.Text = "";
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Code")
            {
                textBox1.MaxLength = 3;
                string sql = "SELECT * FROM EMPLOYEE E NATURAL JOIN SALARY S WHERE E.EMP_CODE = S.EMP_CODE AND E.EMP_CODE = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    string sex = reader.GetString("EMP_SEX");
                    string hiredate = reader.GetString("EMP_HIREDATE");
                    string tel = reader.GetString("EMP_TEL");
                    string address = reader.GetString("EMP_ADDRESS");
                    string type = reader.GetString("EMP_TYPE");
                    string status = reader.GetString("EMP_STATUS");
                    string branch = reader.GetString("BRAN_CODE");
                    string hour = reader.GetString("F_CHG_HOUR");
                    dataGridView1.Rows.Add(code, name, surname, hour, sex, hiredate, tel, address, type, status, branch);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM EMPLOYEE WHERE EMP_CODE = '" + textBox1.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label34.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox3.Text == "Tel")
            {
                textBox1.MaxLength = 10;
                string sql = "SELECT * FROM EMPLOYEE E NATURAL JOIN SALARY S WHERE E.EMP_CODE = S.EMP_CODE AND E.EMP_TEL = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    string sex = reader.GetString("EMP_SEX");
                    string hiredate = reader.GetString("EMP_HIREDATE");
                    string tel = reader.GetString("EMP_TEL");
                    string address = reader.GetString("EMP_ADDRESS");
                    string type = reader.GetString("EMP_TYPE");
                    string status = reader.GetString("EMP_STATUS");
                    string branch = reader.GetString("BRAN_CODE");
                    string hour = reader.GetString("F_CHG_HOUR");
                    dataGridView1.Rows.Add(code, name, surname, hour, sex, hiredate, tel, address, type, status, branch);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM EMPLOYEE WHERE EMP_TEL = '" + textBox1.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label34.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox3.Text == "Type")
            {
                textBox1.MaxLength = 1;
                string sql = "SELECT * FROM EMPLOYEE E NATURAL JOIN SALARY S WHERE E.EMP_CODE = S.EMP_CODE AND E.EMP_TYPE = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    string sex = reader.GetString("EMP_SEX");
                    string hiredate = reader.GetString("EMP_HIREDATE");
                    string tel = reader.GetString("EMP_TEL");
                    string address = reader.GetString("EMP_ADDRESS");
                    string type = reader.GetString("EMP_TYPE");
                    string status = reader.GetString("EMP_STATUS");
                    string branch = reader.GetString("BRAN_CODE");
                    string hour = reader.GetString("F_CHG_HOUR");
                    dataGridView1.Rows.Add(code, name, surname, hour, sex, hiredate, tel, address, type, status, branch);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM EMPLOYEE WHERE EMP_TYPE = '" + textBox1.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label34.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox3.Text == "Branch")
            {
                textBox1.MaxLength = 1;
                string sql = "SELECT * FROM EMPLOYEE E NATURAL JOIN SALARY S WHERE E.EMP_CODE = S.EMP_CODE AND E.BRAN_CODE = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    string sex = reader.GetString("EMP_SEX");
                    string hiredate = reader.GetString("EMP_HIREDATE");
                    string tel = reader.GetString("EMP_TEL");
                    string address = reader.GetString("EMP_ADDRESS");
                    string type = reader.GetString("EMP_TYPE");
                    string status = reader.GetString("EMP_STATUS");
                    string branch = reader.GetString("BRAN_CODE");
                    string hour = reader.GetString("F_CHG_HOUR");
                    dataGridView1.Rows.Add(code, name, surname, hour, sex, hiredate, tel, address, type, status, branch);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM EMPLOYEE WHERE BRAN_CODE = '" + textBox1.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label34.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox3.Text == "Name Surname")
            {
                textBox1.MaxLength = 41;
                string a = textBox1.Text;
                string[] b = a.Split(' ');
                string sql = "SELECT * FROM EMPLOYEE E NATURAL JOIN SALARY S WHERE E.EMP_CODE = S.EMP_CODE AND E.EMP_FNAME = '" + b[0] + "' AND E.EMP_LNAME ='" + b[1] + "'  ";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    string sex = reader.GetString("EMP_SEX");
                    string hiredate = reader.GetString("EMP_HIREDATE");
                    string tel = reader.GetString("EMP_TEL");
                    string address = reader.GetString("EMP_ADDRESS");
                    string type = reader.GetString("EMP_TYPE");
                    string status = reader.GetString("EMP_STATUS");
                    string branch = reader.GetString("BRAN_CODE");
                    string hour = reader.GetString("F_CHG_HOUR");
                    dataGridView1.Rows.Add(code, name, surname, hour, sex, hiredate, tel, address, type, status, branch);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM EMPLOYEE WHERE EMP_FNAME = '" + b[0] + "' AND EMP_LNAME ='" + b[1] + "'  ";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label34.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox3.Text == "Name")
            {
                textBox1.MaxLength = 20;
                string sql = "SELECT * FROM EMPLOYEE E NATURAL JOIN SALARY S WHERE E.EMP_CODE = S.EMP_CODE AND E.EMP_FNAME = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    string sex = reader.GetString("EMP_SEX");
                    string hiredate = reader.GetString("EMP_HIREDATE");
                    string tel = reader.GetString("EMP_TEL");
                    string address = reader.GetString("EMP_ADDRESS");
                    string type = reader.GetString("EMP_TYPE");
                    string status = reader.GetString("EMP_STATUS");
                    string branch = reader.GetString("BRAN_CODE");
                    string hour = reader.GetString("F_CHG_HOUR");
                    dataGridView1.Rows.Add(code, name, surname, hour, sex, hiredate, tel, address, type, status, branch);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM EMPLOYEE WHERE EMP_FNAME = '" + textBox1.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label34.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox3.Text == "Surname")
            {
                textBox1.MaxLength = 20;
                string sql = "SELECT * FROM EMPLOYEE E NATURAL JOIN SALARY S WHERE E.EMP_CODE = S.EMP_CODE AND E.EMP_LNAME = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    string sex = reader.GetString("EMP_SEX");
                    string hiredate = reader.GetString("EMP_HIREDATE");
                    string tel = reader.GetString("EMP_TEL");
                    string address = reader.GetString("EMP_ADDRESS");
                    string type = reader.GetString("EMP_TYPE");
                    string status = reader.GetString("EMP_STATUS");
                    string branch = reader.GetString("BRAN_CODE");
                    string hour = reader.GetString("F_CHG_HOUR");
                    dataGridView1.Rows.Add(code, name, surname, hour, sex, hiredate, tel, address, type, status, branch);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM EMPLOYEE WHERE EMP_LNAME = '" + textBox1.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label34.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox3.Text == "Hiredate")
            {
                textBox1.MaxLength = 10;
                string sql = "SELECT * FROM EMPLOYEE E NATURAL JOIN SALARY S WHERE E.EMP_CODE = S.EMP_CODE AND E.EMP_HIREDATE = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    string sex = reader.GetString("EMP_SEX");
                    string hiredate = reader.GetString("EMP_HIREDATE");
                    string tel = reader.GetString("EMP_TEL");
                    string address = reader.GetString("EMP_ADDRESS");
                    string type = reader.GetString("EMP_TYPE");
                    string status = reader.GetString("EMP_STATUS");
                    string branch = reader.GetString("BRAN_CODE");
                    string hour = reader.GetString("F_CHG_HOUR");
                    dataGridView1.Rows.Add(code, name, surname, hour, sex, hiredate, tel, address, type, status, branch);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM EMPLOYEE WHERE EMP_TIMESTAMP = '" + textBox1.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label34.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            
            else if (comboBox3.Text == "Status")
            {
                textBox1.MaxLength = 20;
                string sql = "SELECT * FROM E NATURAL JOIN SALARY S WHERE E.EMP_CODE = S.EMP_CODE AND E.EMP_STATUS = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    string sex = reader.GetString("EMP_SEX");
                    string hiredate = reader.GetString("EMP_HIREDATE");
                    string tel = reader.GetString("EMP_TEL");
                    string address = reader.GetString("EMP_ADDRESS");
                    string type = reader.GetString("EMP_TYPE");
                    string status = reader.GetString("EMP_STATUS");
                    string branch = reader.GetString("BRAN_CODE");
                    string hour = reader.GetString("F_CHG_HOUR");
                    dataGridView1.Rows.Add(code, name, surname, hour, sex, hiredate, tel, address, type, status, branch);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM EMPLOYEE WHERE EMP_STATUS = '" + textBox1.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label34.Text = reader.GetString("EMP");
                }
                con.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            bool kuy = true;
            if(kuy)
            {
                bool ch = false;
                string sql = "SELECT * FROM EMPLOYEE WHERE EMP_CODE = '" + textBox12.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ch = true;
                }
                con.Close();
                if (!ch)
                {
                    kuy = false;
                    DialogResult dl = MessageBox.Show("This person is not in list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (kuy)
            {
                if (textBox12.Text.Length < 3)
                {
                    DialogResult dl = MessageBox.Show("Please input a Code.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sql = "SELECT * FROM EMPLOYEE WHERE EMP_CODE = '" + textBox12.Text + "'";
                    sql = "UPDATE EMPLOYEE SET EMP_FNAME = '" + textBox13.Text + "',EMP_LNAME = '" + textBox14.Text + "',EMP_SEX = '" + textBox15.Text + "',EMP_TEL = '" + textBox16.Text + "',EMP_ADDRESS = '" + textBox17.Text + "',EMP_TYPE = '" + textBox18.Text + "',BRAN_CODE = '" + textBox19.Text + "',EMP_STATUS = '" + textBox23.Text + "' WHERE EMP_CODE = '" + textBox12.Text + "'";
                    MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult dl = MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        MessageBox.Show("Updated success.");
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        textBox16.Text = "";
                        textBox17.Text = "";
                        textBox18.Text = "";
                        textBox19.Text = "";
                        textBox23.Text = "";
                    }
                    con.Close();
                }
            }
        }
        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {
            textBox12.BackColor = Color.White;
            bool k = true;
            if (textBox12.Text != "")
            {
                int number;
                if (!Int32.TryParse(textBox12.Text, out number))
                {
                    k = false;
                    MessageBox.Show("Please input only digit.", "Check your code.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox12.Focus();
                    textBox12.BackColor = Color.IndianRed;
                }
            }
            if (textBox12.Text.Length == 3 && k)
            {
                bool ch = false;
                string sql = "SELECT * FROM EMPLOYEE WHERE EMP_CODE = '" + textBox12.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ch = true;
                    textBox13.Text = reader.GetString("EMP_FNAME");
                    textBox14.Text = reader.GetString("EMP_LNAME");
                    textBox15.Text = reader.GetString("EMP_SEX");
                    textBox16.Text = reader.GetString("EMP_TEL");
                    textBox17.Text = reader.GetString("EMP_ADDRESS");
                    textBox18.Text = reader.GetString("EMP_TYPE");
                    textBox19.Text = reader.GetString("BRAN_CODE");
                    textBox23.Text = reader.GetString("EMP_STATUS");
                }
                con.Close();
                if (!ch)
                {
                    DialogResult dl = MessageBox.Show("This person is not in list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";
                textBox19.Text = "";
                textBox23.Text = "";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox3.Text == "Code")
            {
                textBox1.MaxLength = 3;
            }
            else if (comboBox3.Text == "Name Surname")
            {
                textBox1.MaxLength = 41;
            }
            else if (comboBox3.Text == "Name")
            {
                textBox1.MaxLength = 20;
            }
            else if (comboBox3.Text == "Surname")
            {
                textBox1.MaxLength = 20;
            }
            else if (comboBox3.Text == "Hiredate")
            {
                textBox1.MaxLength = 10;
            }
            else if (comboBox3.Text == "Tel")
            {
                textBox1.MaxLength = 10;
            }
            else if (comboBox3.Text == "Type")
            {
                textBox1.MaxLength = 1;
            }
            else if (comboBox3.Text == "Branch")
            {
                textBox1.MaxLength = 1;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM EMPLOYEE E NATURAL JOIN SALARY S WHERE E.EMP_CODE = S.EMP_CODE";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                string code = reader.GetString("EMP_CODE");
                string name = reader.GetString("EMP_FNAME");
                string surname = reader.GetString("EMP_LNAME");
                string sex = reader.GetString("EMP_SEX");
                string hiredate = reader.GetString("EMP_HIREDATE");
                string tel = reader.GetString("EMP_TEL");
                string address = reader.GetString("EMP_ADDRESS");
                string type = reader.GetString("EMP_TYPE");
                string status = reader.GetString("EMP_STATUS");
                string branch = reader.GetString("BRAN_CODE");
                string hour = reader.GetString("F_CHG_HOUR");
                dataGridView1.Rows.Add(code, name, surname, hour, sex, hiredate, tel, address, type, status, branch);
            }
            con.Close();
            sql = "SELECT COUNT(EMP_CODE) AS EMP FROM EMPLOYEE";
            con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label34.Text = reader.GetString("EMP");
            }
            con.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Can't enter with manual");
            comboBox3.Text = "Select";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Hiredate")
            {
                textBox1.Text = "YYYY-MM-DD";
                textBox1.ForeColor = Color.LightGray;
            }
            else
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "YYYY-MM-DD")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            string sql = "SELECT HO_CODE,HO_TIMESTAMP,EMP_CODE,EMP_FNAME,EMP_LNAME FROM HOLIDAY H NATURAL JOIN HOLIDAY_DETAIL HD NATURAL JOIN EMPLOYEE E WHERE H.HO_CODE = HD.HO_CODE AND HD.EMP_CODE = E.EMP_CODE";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView2.Rows.Clear();
            while (reader.Read())
            {
                string time = reader.GetString("HO_TIMESTAMP");
                string emp_code = reader.GetString("EMP_CODE");
                string name = reader.GetString("EMP_FNAME");
                string surname = reader.GetString("EMP_LNAME");
                dataGridView2.Rows.Add(time, emp_code, name, surname);
            }
            con.Close();
            sql = "SELECT COUNT(EMP_CODE) AS EMP FROM HOLIDAY H NATURAL JOIN HOLIDAY_DETAIL HD NATURAL JOIN EMPLOYEE E WHERE H.HO_CODE = HD.HO_CODE AND HD.EMP_CODE = E.EMP_CODE";
            con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label36.Text = reader.GetString("EMP");
            }
            con.Close();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Date")
            {
                textBox20.MaxLength = 10;
            }
            else if (comboBox4.Text == "Emp_Code")
            {
                textBox20.MaxLength = 3;
            }
            else if (comboBox4.Text == "Name Surname")
            {
                textBox20.MaxLength = 41;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Date")
            {
                textBox20.MaxLength = 10;
                string sql = "SELECT HO_CODE,HO_TIMESTAMP,EMP_CODE,EMP_FNAME,EMP_LNAME FROM HOLIDAY H NATURAL JOIN HOLIDAY_DETAIL HD NATURAL JOIN EMPLOYEE E WHERE H.HO_CODE = HD.HO_CODE AND HD.EMP_CODE = E.EMP_CODE AND HO_TIMESTAMP = '" + textBox20.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    string time = reader.GetString("HO_TIMESTAMP");
                    string emp_code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    dataGridView2.Rows.Add(time, emp_code, name, surname);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM HOLIDAY H NATURAL JOIN HOLIDAY_DETAIL HD NATURAL JOIN EMPLOYEE E WHERE H.HO_CODE = HD.HO_CODE AND HD.EMP_CODE = E.EMP_CODE AND HO_TIMESTAMP = '" + textBox20.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label36.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox4.Text == "Emp_Code")
            {
                textBox20.MaxLength = 3;
                string sql = "SELECT HO_CODE,HO_TIMESTAMP,EMP_CODE,EMP_FNAME,EMP_LNAME FROM HOLIDAY H NATURAL JOIN HOLIDAY_DETAIL HD NATURAL JOIN EMPLOYEE E WHERE H.HO_CODE = HD.HO_CODE AND HD.EMP_CODE = E.EMP_CODE AND E.EMP_CODE = '" + textBox20.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    string time = reader.GetString("HO_TIMESTAMP");
                    string emp_code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    dataGridView2.Rows.Add(time, emp_code, name, surname);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM HOLIDAY H NATURAL JOIN HOLIDAY_DETAIL HD NATURAL JOIN EMPLOYEE E WHERE H.HO_CODE = HD.HO_CODE AND HD.EMP_CODE = E.EMP_CODE AND E.EMP_CODE = '" + textBox20.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label36.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox4.Text == "Name Surname")
            {
                textBox20.MaxLength = 20;
                string a = textBox20.Text;
                string[] b = a.Split(' ');
                string sql = "SELECT HO_CODE,HO_TIMESTAMP,EMP_CODE,EMP_FNAME,EMP_LNAME FROM HOLIDAY H NATURAL JOIN HOLIDAY_DETAIL HD NATURAL JOIN EMPLOYEE E WHERE H.HO_CODE = HD.HO_CODE AND HD.EMP_CODE = E.EMP_CODE AND E.EMP_FNAME = '" + b[0] + "'AND E.EMP_LNAME = '" + b[1] + "'" ;
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    string time = reader.GetString("HO_TIMESTAMP");
                    string emp_code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string surname = reader.GetString("EMP_LNAME");
                    dataGridView2.Rows.Add(time, emp_code, name, surname);
                }
                con.Close();
                sql = "SELECT COUNT(EMP_CODE) AS EMP FROM HOLIDAY H NATURAL JOIN HOLIDAY_DETAIL HD NATURAL JOIN EMPLOYEE E WHERE H.HO_CODE = HD.HO_CODE AND HD.EMP_CODE = E.EMP_CODE AND E.EMP_FNAME = '" + b[0] + "'AND E.EMP_LNAME = '" + b[1] + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label36.Text = reader.GetString("EMP");
                }
                con.Close();
            }
        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button6.PerformClick();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Date")
            {
                textBox20.Text = "YYYY-MM-DD";
                textBox20.ForeColor = Color.LightGray;
            }
            else
            {
                textBox20.Text = "";
                textBox20.ForeColor = Color.Black;
            }
        }

        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Can't enter with manual");
            comboBox4.Text = "Select";
        }

        private void textBox20_Enter(object sender, EventArgs e)
        {
            if(textBox20.Text == "YYYY-MM-DD")
            {
                textBox20.Text = "";
                textBox20.ForeColor = Color.Black;
            }
        }
        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button7.PerformClick();
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button7.PerformClick();
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button7.PerformClick();
        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button7.PerformClick();
        }


        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button7.PerformClick();
        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button7.PerformClick();
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button7.PerformClick();
        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button7.PerformClick();
        }


        //-----------------------Borrow--------------------------------------------------Borrow------------------------------//


        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Can't enter with manual");
            comboBox5.Text = "Select";
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

            if (comboBox5.Text == "Emp_Code")
            {
                textBox21.MaxLength = 3;
            }
            else if (comboBox5.Text == "Branch_Code")
            {
                textBox21.MaxLength = 1;
            }
            else if (comboBox5.Text == "Branch_Name")
            {
                textBox21.MaxLength = 20;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sql = "SELECT BORROW_EMPLOYEE.EMP_CODE,EMPLOYEE.EMP_FNAME,EMPLOYEE.EMP_LNAME,BORROW_EMPLOYEE.BE_START,BORROW_EMPLOYEE.BE_END,BORROW_EMPLOYEE.BRAN_CODE,BRANCH.BRAN_NAME FROM EMPLOYEE RIGHT OUTER JOIN BORROW_EMPLOYEE ON BORROW_EMPLOYEE.EMP_CODE = EMPLOYEE.EMP_CODE LEFT OUTER JOIN BRANCH ON BORROW_EMPLOYEE.BRAN_CODE = BRANCH.BRAN_CODE ORDER BY BORROW_EMPLOYEE.BE_START";  
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView3.Rows.Clear();
            string emp_code, name, surname, start, end, bcode, bname;
            while (reader.Read())
            {
                emp_code = reader.GetString("EMP_CODE");
                name = reader.GetString("EMP_FNAME");
                surname = reader.GetString("EMP_LNAME");
                start = reader.GetString("BE_START");
                end = reader.GetString("BE_END");
                bcode = reader.GetString("BRAN_CODE");
                bname = reader.GetString("BRAN_NAME");
                dataGridView3.Rows.Add(emp_code, name, surname, start, end, bcode, bname);
            }
            con.Close();
            sql = "SELECT COUNT(BORROW_EMPLOYEE.EMP_CODE) AS EMP FROM EMPLOYEE RIGHT OUTER JOIN BORROW_EMPLOYEE ON BORROW_EMPLOYEE.EMP_CODE = EMPLOYEE.EMP_CODE LEFT OUTER JOIN BRANCH ON BORROW_EMPLOYEE.BRAN_CODE = BRANCH.BRAN_CODE";
            con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label38.Text = reader.GetString("EMP");
            }
            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Emp_Code")
            {
                textBox21.MaxLength = 3;
                string sql = "SELECT BORROW_EMPLOYEE.EMP_CODE,EMPLOYEE.EMP_FNAME,EMPLOYEE.EMP_LNAME,BORROW_EMPLOYEE.BE_START,BORROW_EMPLOYEE.BE_END,BORROW_EMPLOYEE.BRAN_CODE,BRANCH.BRAN_NAME FROM EMPLOYEE RIGHT OUTER JOIN BORROW_EMPLOYEE ON BORROW_EMPLOYEE.EMP_CODE = EMPLOYEE.EMP_CODE LEFT OUTER JOIN BRANCH ON BORROW_EMPLOYEE.BRAN_CODE = BRANCH.BRAN_CODE WHERE BORROW_EMPLOYEE.EMP_CODE = '" + textBox21.Text + "' ORDER BY BORROW_EMPLOYEE.BE_START";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView3.Rows.Clear();
                string emp_code, name, surname, start, end, bcode, bname;
                while (reader.Read())
                {
                    emp_code = reader.GetString("EMP_CODE");
                    name = reader.GetString("EMP_FNAME");
                    surname = reader.GetString("EMP_LNAME");
                    start = reader.GetString("BE_START");
                    end = reader.GetString("BE_END");
                    bcode = reader.GetString("BRAN_CODE");
                    bname = reader.GetString("BRAN_NAME");
                    dataGridView3.Rows.Add(emp_code, name, surname, start, end, bcode, bname);
                }
                con.Close();
                sql = "SELECT COUNT(BORROW_EMPLOYEE.EMP_CODE) AS EMP FROM EMPLOYEE RIGHT OUTER JOIN BORROW_EMPLOYEE ON BORROW_EMPLOYEE.EMP_CODE = EMPLOYEE.EMP_CODE LEFT OUTER JOIN BRANCH ON BORROW_EMPLOYEE.BRAN_CODE = BRANCH.BRAN_CODE WHERE BORROW_EMPLOYEE.EMP_CODE = '" + textBox21.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label38.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox5.Text == "Branch_Code")
            {
                textBox21.MaxLength = 1;
                string sql = "SELECT BORROW_EMPLOYEE.EMP_CODE,EMPLOYEE.EMP_FNAME,EMPLOYEE.EMP_LNAME,BORROW_EMPLOYEE.BE_START,BORROW_EMPLOYEE.BE_END,BORROW_EMPLOYEE.BRAN_CODE,BRANCH.BRAN_NAME FROM EMPLOYEE RIGHT OUTER JOIN BORROW_EMPLOYEE ON BORROW_EMPLOYEE.EMP_CODE = EMPLOYEE.EMP_CODE LEFT OUTER JOIN BRANCH ON BORROW_EMPLOYEE.BRAN_CODE = BRANCH.BRAN_CODE WHERE BORROW_EMPLOYEE.BRAN_CODE = '" + textBox21.Text + "' ORDER BY BORROW_EMPLOYEE.BE_START";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView3.Rows.Clear();
                string emp_code, name, surname, start, end, bcode, bname;
                while (reader.Read())
                {
                    emp_code = reader.GetString("EMP_CODE");
                    name = reader.GetString("EMP_FNAME");
                    surname = reader.GetString("EMP_LNAME");
                    start = reader.GetString("BE_START");
                    end = reader.GetString("BE_END");
                    bcode = reader.GetString("BRAN_CODE");
                    bname = reader.GetString("BRAN_NAME");
                    dataGridView3.Rows.Add(emp_code, name, surname, start, end, bcode, bname);
                }
                con.Close();
                sql = "SELECT COUNT(BORROW_EMPLOYEE.EMP_CODE) AS EMP FROM EMPLOYEE RIGHT OUTER JOIN BORROW_EMPLOYEE ON BORROW_EMPLOYEE.EMP_CODE = EMPLOYEE.EMP_CODE LEFT OUTER JOIN BRANCH ON BORROW_EMPLOYEE.BRAN_CODE = BRANCH.BRAN_CODE WHERE BORROW_EMPLOYEE.BRAN_CODE = '" + textBox21.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label38.Text = reader.GetString("EMP");
                }
                con.Close();
            }
            else if (comboBox5.Text == "Branch_Name")
            {
                textBox21.MaxLength = 20;
                string sql = "SELECT BORROW_EMPLOYEE.EMP_CODE,EMPLOYEE.EMP_FNAME,EMPLOYEE.EMP_LNAME,BORROW_EMPLOYEE.BE_START,BORROW_EMPLOYEE.BE_END,BORROW_EMPLOYEE.BRAN_CODE,BRANCH.BRAN_NAME FROM EMPLOYEE RIGHT OUTER JOIN BORROW_EMPLOYEE ON BORROW_EMPLOYEE.EMP_CODE = EMPLOYEE.EMP_CODE LEFT OUTER JOIN BRANCH ON BORROW_EMPLOYEE.BRAN_CODE = BRANCH.BRAN_CODE WHERE BRANCH.BRAN_NAME = '" + textBox21.Text + "' ORDER BY BORROW_EMPLOYEE.BE_START";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView3.Rows.Clear();
                string emp_code, name, surname, start, end, bcode, bname;
                while (reader.Read())
                {
                    emp_code = reader.GetString("EMP_CODE");
                    name = reader.GetString("EMP_FNAME");
                    surname = reader.GetString("EMP_LNAME");
                    start = reader.GetString("BE_START");
                    end = reader.GetString("BE_END");
                    bcode = reader.GetString("BRAN_CODE");
                    bname = reader.GetString("BRAN_NAME");
                    dataGridView3.Rows.Add(emp_code, name, surname, start, end, bcode, bname);
                }
                con.Close();
                sql = "SELECT COUNT(BORROW_EMPLOYEE.EMP_CODE) AS EMP FROM EMPLOYEE RIGHT OUTER JOIN BORROW_EMPLOYEE ON BORROW_EMPLOYEE.EMP_CODE = EMPLOYEE.EMP_CODE LEFT OUTER JOIN BRANCH ON BORROW_EMPLOYEE.BRAN_CODE = BRANCH.BRAN_CODE WHERE BRANCH.BRAN_NAME = '" + textBox21.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label38.Text = reader.GetString("EMP");
                }
                con.Close();
            }
        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button11.PerformClick();
            }
        }

        private void textBox22_Enter(object sender, EventArgs e)
        {
            if(textBox22.Text == "Position")
            {
                textBox22.Text = "";
                textBox22.ForeColor = Color.Black;
            }
        }

        private void textBox22_Leave(object sender, EventArgs e)
        {
            if (textBox22.Text == "")
            {
                textBox22.Text = "Position";
                textBox22.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool k = true;
            if (textBox2.Text != "")
            {
                int number;
                if (!Int32.TryParse(textBox2.Text, out number))
                {
                    k = false;
                    MessageBox.Show("Please input only digit.", "Check your code.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            textBox5.Focus();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            textBox12.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
