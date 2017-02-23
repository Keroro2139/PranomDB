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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM EVENT";
            MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string code = reader.GetString("E_CODE");
                string promotion = reader.GetString("E_NAME");
                string start = reader.GetString("E_START");
                string end = reader.GetString("E_STOP");
                string des = reader.GetString("E_DESCRIPTION");
                dataGridView2.Rows.Add(code, promotion, start, end, des);
            }
            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Description";
            link.Name = "des";
            link.Text = "DETAIL";
            link.UseColumnTextForLinkValue = true;
            dataGridView2.Columns.Add(link);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Code" && textBox1.Text.Length == 2)
            {

                string sql = "SELECT * FROM EVENT WHERE E_CODE = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("E_CODE");
                    string promotion = reader.GetString("E_NAME");
                    string start = reader.GetString("E_START");
                    string end = reader.GetString("E_STOP");

                    dataGridView2.Rows.Add(code, promotion, start, end);
                }
                con.Close();
            }
            else if (comboBox1.Text == "Promotion" && textBox1.Text.Length <= 500)
            {
                textBox1.Text = "Name";
                textBox1.ForeColor = Color.LightGray;
                string sql = "SELECT * FROM EVENT WHERE E_NAME = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("E_CODE");
                    string promotion = reader.GetString("E_NAME");
                    string start = reader.GetString("E_START");
                    string end = reader.GetString("E_STOP");

                    dataGridView2.Rows.Add(code, promotion, start, end);
                }
                con.Close();
            }
            else if (comboBox1.Text == "Start")
            {
                textBox1.Text = "YYYY-MM-DD";
                textBox1.ForeColor = Color.LightGray;
                string sql = "SELECT * FROM EVENT WHERE E_START = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("E_CODE");
                    string promotion = reader.GetString("E_NAME");
                    string start = reader.GetString("E_START");
                    string end = reader.GetString("E_STOP");

                    dataGridView2.Rows.Add(code, promotion, start, end);
                }
                con.Close();
            }
            else if (comboBox1.Text == "End")
            {
                textBox1.Text = "YYYY-MM-DD";
                textBox1.ForeColor = Color.LightGray;
                string sql = "SELECT * FROM EVENT WHERE E_STOP = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("E_CODE");
                    string promotion = reader.GetString("E_NAME");
                    string start = reader.GetString("E_START");
                    string end = reader.GetString("E_STOP");

                    dataGridView2.Rows.Add(code, promotion, start, end);
                }
                con.Close();
            }
            else
            {
                dataGridView2.Rows.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool c = true, k = true;
            if (textBox2.Text == "00" || textBox3.Text == "Name" || textBox4.Text == "YYYY-MM-DD" || textBox5.Text == "YYYY-MM-DD" || textBox6.Text == "Browser")
            {
                k = false;
                MessageBox.Show("Please, input all data.");
            }
            if (k)
            {
                string sql = "SELECT * FROM EVENT";
                sql = "INSERT INTO EVENT (E_CODE,E_NAME,E_START,E_STOP,E_DESCRIPTION) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
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
                    MessageBox.Show("Add promotion complete!");
                textBox2.Text = "00";
                textBox2.ForeColor = Color.LightGray;
                textBox3.Text = "Name";
                textBox3.ForeColor = Color.LightGray;
                textBox4.Text = "YYYY-MM-DD";
                textBox4.ForeColor = Color.LightGray;
                textBox5.Text = "YYYY-MM-DD";
                textBox5.ForeColor = Color.LightGray;
                textBox6.Text = "Browser";
                textBox6.ForeColor = Color.LightGray;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Can't enter with manual");
            comboBox1.Text = "Select";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "-------Select---------";
            textBox1.Text = "";
            string sql = "SELECT * FROM EVENT";
            MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView2.Rows.Clear();
            while (reader.Read())
            {
                string code = reader.GetString("E_CODE");
                string promotion = reader.GetString("E_NAME");
                string start = reader.GetString("E_START");
                string end = reader.GetString("E_STOP");
                string des = reader.GetString("E_DESCRIPTION");
                dataGridView2.Rows.Add(code, promotion, start, end, des);
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "SELECT * FROM EVENT";
            MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                string des = reader.GetString("E_DESCRIPTION");
                if (e.ColumnIndex == 4 && e.RowIndex == count)
                {
                    System.Diagnostics.Process.Start(des);
                }
                count++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you want to clear all this data?", "Clear", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                textBox2.Text = "00";
                textBox2.ForeColor = Color.LightGray;
                textBox3.Text = "Promotion";
                textBox3.ForeColor = Color.LightGray;
                textBox4.Text = "YYYY-MM-DD";
                textBox4.ForeColor = Color.LightGray;
                textBox5.Text = "YYYY-MM-DD";
                textBox5.ForeColor = Color.LightGray;
                textBox6.Text = "Browser";
                textBox6.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "00";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "00")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool hum = true;
            if (hum)
            {
                bool ch = false;
                string sql = "SELECT * FROM EVENT WHERE E_CODE = '" + textBox7.Text + "'";
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
                if (textBox7.Text.Length == 0 || textBox8.Text.Length == 0)
                {
                    DialogResult dl = MessageBox.Show("Please input a Code.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dl = MessageBox.Show("Do you want to remove" + System.Environment.NewLine + "Code : " + textBox7.Text + System.Environment.NewLine + "Name : " + textBox8.Text, "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        string sql = "DELETE FROM EVENT WHERE E_CODE = '" + textBox7.Text + "'";
                        MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("remove success.");
                        textBox7.Text = "";
                        textBox8.Text = "";
                    }
                }
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "-------Select---------";
            textBox1.Text = "";
            string sql = "SELECT * FROM EVENT";
            MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView2.Rows.Clear();
            while (reader.Read())
            {
                string code = reader.GetString("E_CODE");
                string promotion = reader.GetString("E_NAME");
                string start = reader.GetString("E_START");
                string end = reader.GetString("E_STOP");
                string des = reader.GetString("E_DESCRIPTION");
                dataGridView2.Rows.Add(code, promotion, start, end, des);
            }
            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Description";
            link.Name = "des";
            link.Text = "DETAIL";
            link.UseColumnTextForLinkValue = true;
            dataGridView2.Columns.Add(link);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
            bool k = true;
            if (textBox7.Text != "")
            {
                int number;
                if (!Int32.TryParse(textBox7.Text, out number))
                {
                    k = false;
                    MessageBox.Show("Please input only digit.", "Check your code.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox7.Focus();
                    textBox7.BackColor = Color.IndianRed;
                }
            }
            if (textBox7.Text.Length == 2 && k)
            {
                bool ch = false;
                string sql = "SELECT * FROM EVENT WHERE E_CODE = '" + textBox7.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ch = true;
                    textBox8.Text = reader.GetString("E_NAME");
                    textBox8.ForeColor = Color.Black;
                }
                con.Close();
                if (!ch)
                {
                    DialogResult dl = MessageBox.Show("This person is not in list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textBox8.Text = "";
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "00";
                textBox7.ForeColor = Color.LightGray;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "00")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Promotion";
                textBox8.ForeColor = Color.LightGray;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Promotion")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you want to clear all this data?", "Clear", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                textBox7.Text = "00";
                textBox7.ForeColor = Color.LightGray;
                textBox8.Text = "Promotion";
                textBox8.ForeColor = Color.LightGray;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Promotion")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Promotion";
                textBox3.ForeColor = Color.LightGray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "YYYY-MM-DD")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "YYYY-MM-DD";
                textBox4.ForeColor = Color.LightGray;
            }
        }


        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "YYYY-MM-DD";
                textBox5.ForeColor = Color.LightGray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "YYYY-MM-DD")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Browser")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Browser";
                textBox6.ForeColor = Color.LightGray;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.White;
            bool k = true;
            if (textBox9.Text != "")
            {
                int number;
                if (!Int32.TryParse(textBox9.Text, out number))
                {
                    k = false;
                    MessageBox.Show("Please input only digit.", "Check your code.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox12.Focus();
                    textBox12.BackColor = Color.IndianRed;
                }
            }
            if (textBox9.Text.Length == 2 && k)
            {
                bool ch = false;
                string sql = "SELECT * FROM EVENT WHERE E_CODE = '" + textBox9.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ch = true;
                    textBox10.Text = reader.GetString("E_NAME");
                    textBox11.Text = reader.GetString("E_DESCRIPTION");
                    textBox12.Text = reader.GetString("E_START");
                    textBox13.Text = reader.GetString("E_STOP");
                }
                con.Close();
                if (!ch)
                {
                    DialogResult dl = MessageBox.Show("This person is not in list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button7.PerformClick();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool kuy = true;
            if (kuy)
            {
                bool ch = false;
                string sql = "SELECT * FROM EVENT WHERE E_CODE = '" + textBox9.Text + "'";
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
                if (textBox12.Text.Length < 2)
                {
                    DialogResult dl = MessageBox.Show("Please input a Code.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sql = "SELECT * FROM EVENT WHERE E_CODE = '" + textBox9.Text + "'";
                    sql = "UPDATE EVENT SET E_NAME = '" + textBox10.Text + "',E_DESCRIPTION = '" + textBox11.Text + "',E_START = '" + textBox12.Text + "',E_STOP = '" + textBox13.Text + "' WHERE E_CODE = '" + textBox9.Text + "'";
                    MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult dl = MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        MessageBox.Show("Updated success.");
                        textBox9.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                    }
                    con.Close();
                }
            }
        }


    }
}
