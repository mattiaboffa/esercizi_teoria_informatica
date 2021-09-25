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
    public partial class form_figlia : Form
    {
        public form_figlia()
        {
            InitializeComponent();
        }

        private void btnF3_1_Click(object sender, EventArgs e)
        {
            if(Owner!=null)
                MessageBox.Show("From figlia di: " + Owner.Text);
        }
    }
}
