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
            lbl1.Text = "Llene la informacion";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            lbl1.Text = ""; lbl2.Text ="";
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnfecha_Click(object sender, EventArgs e)
        {
            DateTime date = calendario.SelectionStart;


        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            Form formulario = new QUIZ();
            formulario.Show();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            lbl2.Text = "Usuario " + txtb1.Text + " su cita ha sido apartada.";
            
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl6.Text = (String)lst.Items[lst.SelectedIndex];
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl9.Text = (String)comboBox1.Items[comboBox1.SelectedIndex];
        }
    }
}
