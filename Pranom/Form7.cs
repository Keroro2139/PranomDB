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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ShowSalary_Click(object sender, EventArgs e)
        {
            GridShow.Show();
            GridFull.Hide();
            GridPart.Hide();
            string sql = "SELECT *,EMP_TIMEWORK * EMP_CHG_HOUR AS TOTAL FROM EMPLOYEE";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            GridShow.Rows.Clear();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string code = reader.GetString("EMP_CODE");
                string fname = reader.GetString("EMP_FNAME");
                string lname = reader.GetString("EMP_LNAME");
                string hour = reader.GetString("EMP_TIMEWORK");
                string chg = reader.GetString("EMP_CHG_HOUR");
                string total = reader.GetString("TOTAL");
                GridShow.Rows.Add(code, fname, lname, hour, chg, total);
            }
            con.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            GridFull.Hide();
            GridPart.Hide();
        }

        private void Fulltime_Click(object sender, EventArgs e)
        {
            GridFull.Show();
            GridShow.Hide();
            GridPart.Hide();
            string sql = "SELECT *,EMP_TIMEWORK * EMP_CHG_HOUR AS TOTAL FROM EMPLOYEE WHERE EMP_TYPE = 'F'";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            GridFull.Rows.Clear();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string code = reader.GetString("EMP_CODE");
                string fname = reader.GetString("EMP_FNAME");
                string lname = reader.GetString("EMP_LNAME");
                string hour = reader.GetString("EMP_TIMEWORK");
                string chg = reader.GetString("EMP_CHG_HOUR");
                string total = reader.GetString("TOTAL");
                GridFull.Rows.Add(code, fname, lname, hour, chg, total);
            }
            con.Close();
        }

        private void Parttime_Click(object sender, EventArgs e)
        {
            GridPart.Show();
            GridShow.Hide();
            GridFull.Hide();
            string sql = "SELECT *,EMP_TIMEWORK * EMP_CHG_HOUR AS TOTAL FROM EMPLOYEE WHERE EMP_TYPE = 'P'";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            GridPart.Rows.Clear();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string code = reader.GetString("EMP_CODE");
                string fname = reader.GetString("EMP_FNAME");
                string lname = reader.GetString("EMP_LNAME");
                string hour = reader.GetString("EMP_TIMEWORK");
                string chg = reader.GetString("EMP_CHG_HOUR");
                string total = reader.GetString("TOTAL");
                GridPart.Rows.Add(code, fname, lname, hour, chg, total);
            }
            con.Close();
        }

        private void textSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchSalary.PerformClick();
            }
        }

        private void SearchSalary_Click(object sender, EventArgs e)
        {
            GridShow.Rows.Clear();
            GridShow.Show();
            GridFull.Hide();
            GridPart.Hide();
            if (comboSalary.Text == "Emp_Code")
            {
                string sql = "SELECT *,EMP_TIMEWORK * EMP_CHG_HOUR AS TOTAL FROM EMPLOYEE WHERE EMP_CODE = '" + textSalary.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                GridShow.Rows.Clear();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string code = reader.GetString("EMP_CODE");
                    string fname = reader.GetString("EMP_FNAME");
                    string lname = reader.GetString("EMP_LNAME");
                    string hour = reader.GetString("EMP_TIMEWORK");
                    string chg = reader.GetString("EMP_CHG_HOUR");
                    string total = reader.GetString("TOTAL");
                    GridShow.Rows.Add(code, fname, lname, hour, chg, total);
                }
                con.Close();
            }
        }
    }
}
