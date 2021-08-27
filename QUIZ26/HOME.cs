using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ26
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Let`s gets started";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl2.Text = "good luck";
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            lbl1.Text = ""; lbl2.Text = "";
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }
    }
}
