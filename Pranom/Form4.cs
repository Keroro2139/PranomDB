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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PRODUCT WHERE P_CODE = '" + textBox1.Text + "'";
            MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Clear();
                string session_sql = reader.GetString("P_CODE");
                string session_sql2 = reader.GetString("P_PRICE");
                string session_sql3 = reader.GetString("P_COST");
                string session_sql4 = reader.GetString("P_DURATION");
                string session_sql5 = reader.GetString("P_QOH");
                string session_sql6 = reader.GetString("P_TIMESTAMP");
                string session_sql7 = reader.GetString("P_SALETYPE");
                string session_sql8 = reader.GetString("P_TYPE");
                string session_sql9 = reader.GetString("VEN_CODE");
                dataGridView1.Rows.Add(session_sql, session_sql2, session_sql3, session_sql4, session_sql5, session_sql6, session_sql7, session_sql8, session_sql9);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PRODUCT";
            MySqlConnection con = new MySqlConnection("host=angsila.informatics.buu.ac.th;user=cs57160477;password=cs57160477;database=cs57160477");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string session_sql = reader.GetString("P_CODE");
                string session_sql2 = reader.GetString("P_PRICE");
                string session_sql3 = reader.GetString("P_COST");
                string session_sql4 = reader.GetString("P_DURATION");
                string session_sql5 = reader.GetString("P_QOH");
                string session_sql6 = reader.GetString("P_TIMESTAMP");
                string session_sql7 = reader.GetString("P_SALETYPE");
                string session_sql8 = reader.GetString("P_TYPE");
                string session_sql9 = reader.GetString("VEN_CODE");
                dataGridView1.Rows.Add(session_sql, session_sql2, session_sql3, session_sql4, session_sql5, session_sql6, session_sql7, session_sql8, session_sql9);

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
