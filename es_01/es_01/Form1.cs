using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            //Form2 frm_2 = new Form2();// diciarazione del oggetto allocando dello spazio in memoria con un punatore
            /*Form2 f2;
            f2 = new Form2(); //secondo tipo di scrittura
            f2.Text = "Form 2 creata da designrer";
            f2.Show();*/

            Form2 f2b = new Form2(10);
            f2b.Text = "FORM 2 DA DESINER CON PARAMETRO";
            f2b.Show();
        }

        private void bnt_3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txt_daPassare);
            f2.Text = "from 2 con passaggio di un text box";
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
