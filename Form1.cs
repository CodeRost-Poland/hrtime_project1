using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace HRTIME_Project
{


    public partial class loading_form : Form
    {
        public loading_form()
        {
            InitializeComponent();
        }
        private void loading_form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                progressBar1.PerformStep();
                label2.Text = i.ToString() + "%";
                if (i==100)
                {
                    Form2 f2 = new Form2();
                    f2.ShowDialog(); // Shows Form2
                    this.Close();
                }
            }
        }

    }

}



//-------------------------------------------------
//przeskok do formy
//Form2 f2 = new Form2();
//f2.ShowDialog(); // Shows Form2
//
//odczyt paska 
//progressBar1.Value = 0;
//String sValue = progressBar1.Value.ToString();
//label2.Text = sValue + "%";
//-------------------------------------------------