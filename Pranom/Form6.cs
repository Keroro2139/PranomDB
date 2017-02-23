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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ShowDetail_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM BRANCH B NATURAL JOIN EMPLOYEE E WHERE E.EMP_STATUS = 'MANAGER' AND B.BRAN_CODE = E.BRAN_CODE";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while(reader.Read())
            {
                string code = reader.GetString("BRAN_CODE"), name = reader.GetString("BRAN_NAME"), add = reader.GetString("BRAN_ADDRESS"), tel = reader.GetString("BRAN_TEL");
                string ecode = reader.GetString("EMP_CODE");
                string ename = reader.GetString("EMP_FNAME");
                string sname = reader.GetString("EMP_LNAME");
                dataGridView1.Rows.Add(code, name, add, tel, ecode, ename, sname);
            }
            con.Close();
            sql = "SELECT COUNT(BRAN_CODE) AS AMOUNT FROM BRANCH";
            con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label3.Text = reader.GetString("AMOUNT");
            }
            con.Close();
        }

        private void textDetail_TextChanged(object sender, EventArgs e)
        {
            if (comboDetail.Text == "Code")
            {
                textDetail.MaxLength = 1;
            }
            else if (comboList.Text == "Name")
            {
                comboDetail.MaxLength = 20;
            }
            else if (comboList.Text == "Tel.")
            {
                comboDetail.MaxLength = 10;
            }
            else
            {
                textDetail.MaxLength = 100;
            }
        }

        
        private void SearchDetail_Click(object sender, EventArgs e)
        {
            if (comboDetail.Text == "Code")
            {
                textDetail.MaxLength = 1;
                string sql = "SELECT * FROM BRANCH B NATURAL JOIN EMPLOYEE E WHERE B.BRAN_CODE = '" + textDetail.Text + "' AND E.EMP_STATUS = 'Manager'" ;
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("BRAN_CODE"), name = reader.GetString("BRAN_NAME"), add = reader.GetString("BRAN_ADDRESS"), tel = reader.GetString("BRAN_TEL"), mcode = reader.GetString("EMP_CODE"), mname = reader.GetString("EMP_FNAME"), lname = reader.GetString("EMP_LNAME");
                    dataGridView1.Rows.Add(code, name, add, tel, mcode, mname, lname);
                }
                con.Close();
                sql = "SELECT COUNT(BRAN_CODE) AS AMOUNT FROM BRANCH WHERE BRAN_CODE = '" + textDetail.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label3.Text = reader.GetString("AMOUNT");
                }
                con.Close();
            }
            else if (comboDetail.Text == "Name")
            {
                textDetail.MaxLength = 20;
                string sql = "SELECT * FROM BRANCH B NATURAL JOIN EMPLOYEE E WHERE B.BRAN_NAME = '" + textDetail.Text + "' AND E.EMP_STATUS = 'Manager'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("BRAN_CODE"), name = reader.GetString("BRAN_NAME"), add = reader.GetString("BRAN_ADDRESS"), tel = reader.GetString("BRAN_TEL"), mcode = reader.GetString("EMP_CODE"), mname = reader.GetString("EMP_FNAME"), lname = reader.GetString("EMP_LNAME");
                    dataGridView1.Rows.Add(code, name, add, tel, mcode, mname, lname);
                }
                con.Close();
                sql = "SELECT COUNT(BRAN_CODE) AS AMOUNT FROM BRANCH  WHERE BRAN_NAME = '" + textDetail.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label3.Text = reader.GetString("AMOUNT");
                }
                con.Close();
            }
            else if (comboDetail.Text == "Tel.")
            {
                textDetail.MaxLength = 10;
                string sql = "SELECT * FROM BRANCH WHERE BRAN_TEL = '" + textDetail.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("BRAN_CODE"), name = reader.GetString("BRAN_NAME"), add = reader.GetString("BRAN_ADDRESS"), tel = reader.GetString("BRAN_TEL"), mcode = reader.GetString("EMP_CODE"), mname = reader.GetString("EMP_FNAME"), lname = reader.GetString("EMP_LNAME");
                    dataGridView1.Rows.Add(code, name, add, tel, mcode, mname, lname);
                }
                con.Close();
                sql = "SELECT COUNT(BRAN_CODE) AS AMOUNT FROM BRANCH WHERE BRAN_TEL = '" + textDetail.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label3.Text = reader.GetString("AMOUNT");
                }
                con.Close();
            }
        }
        private void textDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchDetail.PerformClick();
            }
        }
        private void ShowList_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM BRANCH B NATURAL JOIN EMPLOYEE E WHERE B.BRAN_CODE = E.BRAN_CODE ORDER BY B.BRAN_CODE";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView2.Rows.Clear();
            while (reader.Read())
            {
                string code = reader.GetString("BRAN_CODE"), Bname = reader.GetString("BRAN_NAME"), Ename = reader.GetString("EMP_FNAME"), Esurname = reader.GetString("EMP_LNAME"), tel = reader.GetString("EMP_TEL"), Ecode = reader.GetString("EMP_CODE");
                dataGridView2.Rows.Add(code, Bname, Ecode, Ename, Esurname, tel);
            }
            con.Close();
            sql = "SELECT COUNT(EMPLOYEE.BRAN_CODE) AS AMOUNT FROM BRANCH NATURAL JOIN EMPLOYEE WHERE BRANCH.BRAN_CODE = EMPLOYEE.BRAN_CODE";
            con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            con.Open();
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label1.Text = reader.GetString("AMOUNT");
            }
            con.Close();
        }
        private void textList_TextChanged(object sender, EventArgs e)
        {
            if(comboList.Text == "Branch_Code")
            {
                textList.MaxLength = 1;
            }
            else if (comboList.Text == "Branch_Name")
            {
                textList.MaxLength = 20;
            }
            else if (comboList.Text == "Emp_Code")
            {
                textList.MaxLength = 3;
            }
            else
            {
                textList.MaxLength = 100;
            }
        }

        private void SearchList_Click(object sender, EventArgs e)
        {
            if (comboList.Text == "Branch_Code")
            {
                textList.MaxLength = 1;
                string sql = "SELECT * FROM BRANCH B NATURAL JOIN EMPLOYEE E WHERE B.BRAN_CODE = E.BRAN_CODE AND BRAN_CODE = '" + textList.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("BRAN_CODE"), Bname = reader.GetString("BRAN_NAME"), Ename = reader.GetString("EMP_FNAME"), Esurname = reader.GetString("EMP_LNAME"), tel = reader.GetString("EMP_TEL"), Ecode = reader.GetString("EMP_CODE");
                    dataGridView2.Rows.Add(code, Bname, Ecode, Ename, Esurname, tel);
                }
                con.Close();
                sql = "SELECT COUNT(BRAN_CODE) AS AMOUNT FROM BRANCH NATURAL JOIN EMPLOYEE WHERE BRANCH.BRAN_CODE = EMPLOYEE.BRAN_CODE AND BRAN_CODE = '" + textList.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader.GetString("AMOUNT");
                }
                con.Close();
            }
            else if (comboList.Text == "Branch_Name")
            {
                textList.MaxLength = 20;
                string sql = "SELECT * FROM BRANCH B NATURAL JOIN EMPLOYEE E WHERE B.BRAN_CODE = E.BRAN_CODE AND BRAN_NAME = '" + textList.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("BRAN_CODE"), Bname = reader.GetString("BRAN_NAME"), Ename = reader.GetString("EMP_FNAME"), Esurname = reader.GetString("EMP_LNAME"), tel = reader.GetString("EMP_TEL"), Ecode = reader.GetString("EMP_CODE");
                    dataGridView2.Rows.Add(code, Bname, Ecode, Ename, Esurname, tel);
                }
                con.Close();
                sql = "SELECT COUNT(BRAN_CODE) AS AMOUNT FROM BRANCH NATURAL JOIN EMPLOYEE WHERE BRANCH.BRAN_CODE = EMPLOYEE.BRAN_CODE AND BRAN_NAME = '" + textList.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader.GetString("AMOUNT");
                }
                con.Close();
            }
            else if (comboList.Text == "Emp_Code")
            {
                textList.MaxLength = 3;
                string sql = "SELECT * FROM BRANCH B NATURAL JOIN EMPLOYEE E WHERE B.BRAN_CODE = E.BRAN_CODE AND E.EMP_CODE = '" + textList.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    string code = reader.GetString("BRAN_CODE"), Bname = reader.GetString("BRAN_NAME"), Ename = reader.GetString("EMP_FNAME"), Esurname = reader.GetString("EMP_LNAME"), tel = reader.GetString("EMP_TEL"), Ecode = reader.GetString("EMP_CODE");
                    dataGridView2.Rows.Add(code, Bname, Ecode, Ename, Esurname, tel);
                }
                con.Close();
                sql = "SELECT COUNT(BRAN_CODE) AS AMOUNT FROM BRANCH NATURAL JOIN EMPLOYEE WHERE BRANCH.BRAN_CODE = EMPLOYEE.BRAN_CODE AND EMPLOYEE.EMP_CODE = '" + textList.Text + "'";
                con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                con.Open();
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader.GetString("AMOUNT");
                }
                con.Close();
            }
        }

        private void textList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchList.PerformClick();
            }
        }

        private void comboDetail_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Can't enter with manual");
            comboDetail.Text = "Select";
        }

        private void comboList_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Can't enter with manual");
            comboList.Text = "Select";
        }
    }
}
