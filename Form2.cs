using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;

namespace HRTIME_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check_min = false; //zmienna kontrolująca długość znaków (minimalny)
            bool check_max = false;//zmienna kontrolująca długość znaków (maksymalny)
            String login_t = textBox2.Text;
            String password_t = textBox1.Text;
            int length_p = password_t.Length;
            int length_l = login_t.Length;
            //Kod sprawdza czy TextBox'y nie zwracają wartości (długości tekstu) <2 i >24
            if (length_l > 24 || length_p > 24)
            {
                check_max = true;
            }
            if (length_l < 2 || length_p < 2)
            {
                check_min = true;
            }
            if (check_min == true || check_max == true)
            {
                MessageBox.Show("Login i/lub Hasło ma długość znaków od 2 do 24 znaków!", "Bład!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                check_max = false;
                check_min = false;
            }

            if(login_t == "admin" && password_t == "admin")
            {
                String dzial = comboBox1.Text;
                MessageBox.Show("Witaj " + login_t + ", zalogowałeś się do sieci " + dzial);
            }


        }

    }
}
