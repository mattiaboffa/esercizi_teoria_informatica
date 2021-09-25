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
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        public Form2(TextBox txt)
        {
            InitializeComponent();
            this.txt = txt;
            //txt.Text = "Ciao da F2!";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txt_f2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnF2_1_Click(object sender, EventArgs e)
        {
            if(txt==null)
            {
                MessageBox.Show("Non è stato passato l'ogetto del textbox");
            }
            else
                MessageBox.Show(txt.Text);
        }

        private void btnf2_2_Click(object sender, EventArgs e)
        {
            if (txt == null)
            {
                MessageBox.Show("Non è stato passato l'ogetto del textbox");
            }
            else
                txt.Text = txt_f2.Text;
        }

        private void btnF2_apriFiglia_Click(object sender, EventArgs e)
        {
            form_figlia f = new form_figlia();
            this.AddOwnedForm(f);
            f.Show();
        }
    }
}
