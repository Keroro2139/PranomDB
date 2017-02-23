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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textCode.BackColor = Color.White;
            bool k = true;
            if (textCode.Text != "")
            {
                int number;
                if (!Int32.TryParse(textCode.Text, out number))
                {
                    k = false;
                    MessageBox.Show("Please input only digit.", "Check your code.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textCode.Focus();
                    textCode.BackColor = Color.IndianRed;
                }
            }
            if(k && textCode.Text.Length == 3)
            {
                bool ch = false;
                string sql = "SELECT * FROM EMPLOYEE WHERE EMP_CODE = '" + textCode.Text + "'";
                MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                DateTime time = DateTime.Now;
                while (reader.Read())
                {
                    ch = true;
                    textName.Text = reader.GetString("EMP_FNAME");
                    textSurname.Text = reader.GetString("EMP_LNAME");
                    
                }
                con.Close();
                if (!ch)
                {
                    DialogResult dl = MessageBox.Show("This person is not in list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textName.Text = "";
                textSurname.Text = "";
            }
        }
        private void Clockin_Click(object sender, EventArgs e)
        {
            bool hum = true;
            if (hum)
            {
                bool ch = false;
                string sql = "SELECT * FROM EMPLOYEE WHERE EMP_CODE = '" + textCode.Text + "'";
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
            if(hum)
            {
                if (textCode.Text.Length == 0)
                {
                    DialogResult dl = MessageBox.Show("Please input a Emp Code.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool hee = true;
                    string sql = "SELECT * FROM TIMEWORK WHERE EMP_CODE = '" + textCode.Text + "' AND TW_STATUS = 'WORKING'";
                    MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        hee = false;
                    }
                    if (hee)
                    {
                        string send = "INSERT INTO TIMEWORK(EMP_CODE,TW_STATUS,TW_DATE,TW_OUT) VALUES('" + textCode.Text + "','WORKING',NOW(),' ')";
                        con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                        MySqlCommand cmd2 = new MySqlCommand(send, con);
                        con.Open();
                        cmd2.ExecuteNonQuery();
                        DialogResult dl1 = MessageBox.Show("Welcome " + textName.Text + " " + textSurname.Text, "Clock In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        textCode.Text = "";
                        textName.Text = "";
                        textSurname.Text = "";
                    }
                    else
                    {
                        DialogResult dl = MessageBox.Show(textName.Text + " " + textSurname.Text + " you are WORKING now!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
        }

        private void textCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Clockin.PerformClick();
            }
        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Can't enter with manual", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string sql = "SELECT * FROM EMPLOYEE WHERE EMP_CODE = '" + textCode.Text + "'";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textName.Text = reader.GetString("EMP_FNAME");
            }
            con.Close();
            if (e.KeyCode == Keys.Enter)
            {
                Clockin.PerformClick();
            }

        }

        private void textSurname_KeyDown(object sender, KeyEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Can't enter with manual", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string sql = "SELECT * FROM EMPLOYEE WHERE EMP_CODE = '" + textCode.Text + "'";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textSurname.Text = reader.GetString("EMP_LNAME");
            }
            con.Close();
            if (e.KeyCode == Keys.Enter)
            {
                Clockin.PerformClick();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT E.EMP_CODE,E.EMP_FNAME,E.EMP_LNAME,T.TW_DATE,T.TW_OUT,T.TW_STATUS FROM EMPLOYEE E RIGHT OUTER JOIN TIMEWORK T ON E.EMP_CODE = T.EMP_CODE";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            GridClokin.Rows.Clear();
            while (reader.Read())
            {
                string timein = reader.GetString("TW_DATE");
                string[] blankin = timein.Split(' ');
                string holdinH = blankin[1], holdinD = blankin[0];
                string[] semiinH = holdinH.Split(':'), semiinD = holdinD.Split('-');
                string hhi = semiinH[0], mmi = semiinH[1], ssi = semiinH[2], ddi = semiinD[2];
                double Houri = double.Parse(hhi), Minutei = double.Parse(mmi), Secondi = double.Parse(ssi), Dayi = double.Parse(ddi);
                //----------------TIME IN-----------------------------------------//
                if (reader.GetString("TW_OUT") == " ")
                {
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string sur = reader.GetString("EMP_LNAME");
                    string time = reader.GetString("TW_DATE");
                    string o = reader.GetString("TW_OUT");
                    string sta = reader.GetString("TW_STATUS");
                    string Amount = "00.00";
                    GridClokin.Rows.Add(code, name, sur, time, o, sta, Amount);
                }
                else
                {
                    string timeout = reader.GetString("TW_OUT");
                    string[] blankout = timeout.Split(' ');
                    string holdoutH = blankout[1], holdoutD = blankout[0];
                    string[] semioutH = holdoutH.Split(':'), semioutD = holdoutD.Split('-'); ;
                    string hho = semioutH[0], mmo = semioutH[1], sso = semioutH[2], ddo = semioutD[2]; ;
                    double Houro = double.Parse(hho), Minuteo = double.Parse(mmo), Secondo = double.Parse(sso), Dayo = double.Parse(ddo);
                    //----------------TIME OUT----------------------------------------//
                    string AS = "", AM = "", AH = "";
                    double AmountSecond = Secondo - Secondi;
                    if (AmountSecond < 0)
                    {
                        if (Minuteo == 0)
                            Minuteo = 59;
                        else
                            Minuteo -= 1;
                        Secondo += 60;
                        AmountSecond = Secondo - Secondi;
                    }
                    if (AmountSecond < 10)
                    {
                        AS = "0" + AmountSecond.ToString();
                    }
                    else
                    {
                        AS = AmountSecond.ToString();
                    }
                    double AmountMinute = 0, AmountHour = 0;
                    AmountMinute = Minuteo - Minutei;
                    if (AmountMinute < 0)
                    {
                        if (Houro == 0)
                            Houro = 59;
                        else
                            Houro -= 1;
                        Minuteo += 60;
                        AmountMinute = Minuteo - Minutei;
                    }
                    if (AmountMinute < 10)
                    {
                        AM = "0" + AmountMinute.ToString();
                    }
                    else
                    {
                        AM = AmountMinute.ToString();
                    }
                    AmountHour = Houro - Houri;
                    if (AmountHour < 0)
                    {
                        Dayo -= 1;
                        Houro += 24;
                        AmountHour = Houro - Houri;
                    }
                    if (AmountHour < 10)
                    {
                        AH = "0" + AmountHour.ToString();
                    }
                    else
                    {
                        AH = AmountHour.ToString();
                    }
                    double AmountDay = Dayo - Dayi;
                    if (AmountDay != 0)
                    {
                        AmountDay = AmountDay * 24;
                        AmountHour += AmountDay;
                        AH = AmountHour.ToString();
                    }
                    string code = reader.GetString("EMP_CODE");
                    string name = reader.GetString("EMP_FNAME");
                    string sur = reader.GetString("EMP_LNAME");
                    string time = reader.GetString("TW_DATE");
                    string o = reader.GetString("TW_OUT");
                    string sta = reader.GetString("TW_STATUS");
                    string Amount = AH + "." + AM;
                    GridClokin.Rows.Add(code, name, sur, time, o, sta, Amount);
                }
            }
            con.Close();

        }

        private void Clockout_Click(object sender, EventArgs e)
        {
            bool hum = true;
            if (hum)
            {
                bool ch = false;
                string sql = "SELECT * FROM EMPLOYEE WHERE EMP_CODE = '" + textCode.Text + "'";
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
                if (textCode.Text.Length == 0)
                {
                    DialogResult dl = MessageBox.Show("Please input a Emp Code.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool hee = false;
                    string sql = "SELECT * FROM TIMEWORK WHERE EMP_CODE = '" + textCode.Text + "' AND TW_STATUS = 'WORKING'";
                    MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        hee = true;
                    }
                    con.Close();
                    if (hee)
                    {

                        string send = "UPDATE TIMEWORK SET TW_OUT = NOW() WHERE EMP_CODE = '" + textCode.Text + "' AND TW_STATUS = 'WORKING'";
                        con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                        MySqlCommand cmd2 = new MySqlCommand(send, con);
                        con.Open();
                        cmd2.ExecuteNonQuery();
                        DialogResult dl = MessageBox.Show("Good bye " + textName.Text + " " + textSurname.Text, "Clock Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();

                        //-----------------INSERT INTO TW_AMOUNT-------------------------------------------------------------------//
                        string s1 = "SELECT * FROM TIMEWORK WHERE EMP_CODE = '" + textCode.Text + "'";
                        MySqlConnection con1 = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                        MySqlCommand c1 = new MySqlCommand(s1, con1);
                        con1.Open();
                        MySqlDataReader r1 = c1.ExecuteReader();
                        int AmountMinute = 0, AmountHour = 0, AmountSecond = 0, AmountDay = 0, AmountMonth = 0, AmountYear = 0;
                        string AS = "", AM = "", AH = "", AD = "", AMM = "", AY = "";
                        while (r1.Read())
                        {
                            string timein = r1.GetString("TW_DATE");
                            string[] blankin = timein.Split(' ');
                            string holdinH = blankin[1], holdinD = blankin[0];
                            string[] semiinH = holdinH.Split(':'), semiinD = holdinD.Split('-');
                            string hhi = semiinH[0], mmi = semiinH[1], ssi = semiinH[2], ddi = semiinD[2], MMi = semiinD[1], yyi = semiinD[0];
                            int Houri = int.Parse(hhi), Minutei = int.Parse(mmi), Secondi = int.Parse(ssi);
                            int Dayi = int.Parse(ddi), Monthi = int.Parse(MMi), Yeari = int.Parse(yyi);
                            //----------------TIME IN----------------------------------------//
                            string timeout = r1.GetString("TW_OUT");
                            string[] blankout = timeout.Split(' ');
                            string holdoutH = blankout[1], holdoutD = blankout[0];
                            string[] semioutH = holdoutH.Split(':'), semioutD = holdoutD.Split('-'); ;
                            string hho = semioutH[0], mmo = semioutH[1], sso = semioutH[2], ddo = semioutD[2], MMo = semioutD[1], yyo = semioutD[0];
                            int Houro = int.Parse(hho), Minuteo = int.Parse(mmo), Secondo = int.Parse(sso);
                            int Dayo = int.Parse(ddo), Montho = int.Parse(MMo), Yearo = int.Parse(yyo);
                            //----------------TIME OUT----------------------------------------//
                            AmountSecond = Secondo - Secondi;
                            if (AmountSecond < 0)
                            {
                                if (Minuteo == 0)
                                    Minuteo = 59;
                                else
                                    Minuteo -= 1;
                                Secondo += 60;
                                AmountSecond = Secondo - Secondi;
                            }
                            if (AmountSecond < 10)
                            {
                                AS = "0" + AmountSecond.ToString();
                            }
                            else
                            {
                                AS = AmountSecond.ToString();
                            }
                            AmountMinute = Minuteo - Minutei;
                            if (AmountMinute < 0)
                            {
                                if (Houro == 0)
                                    Houro = 59;
                                else
                                    Houro -= 1;
                                Minuteo += 60;
                                AmountMinute = Minuteo - Minutei;
                            }
                            if (AmountMinute < 10)
                            {
                                AM = "0" + AmountMinute.ToString();
                            }
                            else
                            {
                                AM = AmountMinute.ToString();
                            }
                            AmountHour = Houro - Houri;
                            if (AmountHour < 0)
                            {
                                Dayo -= 1;
                                Houro += 24;
                                AmountHour = Houro - Houri;
                            }
                            if (AmountHour < 10)
                            {
                                AH = "0" + AmountHour.ToString();
                            }
                            else
                            {
                                AH = AmountHour.ToString();
                            }
                            AmountDay = Dayo - Dayi;
                            if (AmountDay != 0)
                            {
                                AmountDay = AmountDay * 24;
                                AmountHour += AmountDay;
                                AH = AmountHour.ToString();
                            }
                        }
                        con1.Close();
                        string Amount = AH + "." + AM;
                        string s2 = "UPDATE TIMEWORK SET TW_AMOUNT = '" + Amount + "',TW_STATUS = 'NOT WORKING' WHERE EMP_CODE = '" + textCode.Text + "' AND TW_STATUS = 'WORKING'";
                        MySqlConnection con2 = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                        MySqlCommand c2 = new MySqlCommand(s2, con2);
                        con2.Open();
                        c2.ExecuteNonQuery();
                        con2.Close();
                        string s5 = "SELECT * FROM TIMEWORK WHERE EMP_CODE = '" + textCode.Text + "'";
                        MySqlConnection con5 = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                        MySqlCommand c5 = new MySqlCommand(s5, con5);
                        con5.Open();
                        MySqlDataReader r5 = c5.ExecuteReader();
                        double totalm = 0, totalh = 0;
                        while (r5.Read())
                        {
                            string t = r5.GetString("TW_AMOUNT");
                            string[] d = t.Split('.');
                            string h = d[0], m = d[1];
                            double ht = double.Parse(h), mt = double.Parse(m);
                            totalm += mt;
                            if(totalm >= 60)
                            {
                                totalm -= 60;
                                totalh += 1;
                            }
                            totalh += ht;
                        }
                        con5.Close();
                        double Total = totalh + (totalm * 0.01);
                        string s6 = "UPDATE EMPLOYEE SET EMP_TIMEWORK = '" + Total + "' WHERE EMP_CODE = '" + textCode.Text + "'";
                        MySqlConnection con6 = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                        MySqlCommand c6 = new MySqlCommand(s6, con6);
                        con6.Open();
                        c6.ExecuteNonQuery();
                        con6.Close();
                        string s7 = "UPDATE SALARY SET F_HOUR = '" + Total + "' WHERE EMP_CODE = '" + textCode.Text + "'";
                        MySqlConnection con7 = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
                        MySqlCommand c7 = new MySqlCommand(s7, con7);
                        con7.Open();
                        c7.ExecuteNonQuery();
                        con7.Close();
                        textCode.Text = "";
                        textName.Text = "";
                        textSurname.Text = "";
                    }
                    else
                    {
                        DialogResult dl = MessageBox.Show(textName.Text + " " + textSurname.Text + " you are NOT WORKING!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textCode;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TIMEWORK T NATURAL JOIN EMPLOYEE E WHERE E.EMP_CODE = T.EMP_CODE AND T.EMP_CODE = '" + textSearch.Text + "' AND E.EMP_CODE = '" + textSearch.Text + "'";
            MySqlConnection con = new MySqlConnection("host = angsila.informatics.buu.ac.th; user = cs57160477; password = cs57160477; database = cs57160477");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            GridClokin.Rows.Clear();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string code = reader.GetString("EMP_CODE");
                string name = reader.GetString("EMP_FNAME");
                string sur = reader.GetString("EMP_LNAME");
                string time = reader.GetString("TW_DATE");
                string o = reader.GetString("TW_OUT");
                string sta = reader.GetString("TW_STATUS");
                string Amount = reader.GetString("TW_AMOUNT");
                GridClokin.Rows.Add(code, name, sur, time, o, sta, Amount);
            }
            con.Close();
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Search.PerformClick();
            }
        }
    }
}
