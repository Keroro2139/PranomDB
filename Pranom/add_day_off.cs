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
    public partial class add_day_off : Form
    {
        public add_day_off()
        {
            InitializeComponent();
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

        //---------------------------------------------------------------------------------------------------//

        private void button6_Click(object sender, EventArgs e)
        {
            bool c = true, k = true, p = true;
            if (textBox5.Text == "" || textBox9.Text == "" || textBox11.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                k = false;
                DialogResult dl = MessageBox.Show("Please, input all data.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox5.Text.Length != 3)
            {
                p = false;
                DialogResult dl = MessageBox.Show("Please, input code 3 number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text.Length != 3)
            {
                p = false;
                DialogResult dl = MessageBox.Show("Please, input day off code 3 number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (k && p)
            {
                string sql = "SELECT * HOLIDAY_DETAIL";
                sql = "INSERT INTO HOLIDAY_DETAIL (HO_CODE,EMP_CODE,HO_DESCRIPTION) VALUES('" + textBox2.Text + "','" + textBox5.Text + "','" + textBox1.Text + "')";

                string sql_holiday = "SELECT * HOLIDAY";
                sql_holiday = "INSERT INTO HOLIDAY (HO_CODE,HO_TIMESTAMP) VALUES('" + textBox2.Text + "','" + dateTimePicker1.Value.Year.ToString() + dateTimePicker1.Value.ToString("-MM-dd") + "')";

                MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlCommand cmd_add = new MySqlCommand(sql_holiday, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd_add.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception exam)
                {
                    c = false;
                    MessageBox.Show("This code or name is already.");
                }
                if (c)
                {
                    MessageBox.Show("Add Day off complete!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox5.Text = "";
                    textBox9.Text = "";
                    textBox11.Text = "";
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button6.PerformClick();
            }
        }
    }
}
