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
        string doctor;
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

        

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnfecha_Click(object sender, EventArgs e)
        {
            lblfecha.Text = calendario.SelectionStart.Day.ToString() + "/" +
                calendario.SelectionStart.Month.ToString() + "/" +
                calendario.SelectionStart.Year.ToString();
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



        private void rdio1_CheckedChanged(object sender, EventArgs e)
        {
            doctor = "luis Payares";
            lbl10.Text = doctor;
        }

        private void rdio2_CheckedChanged(object sender, EventArgs e)
        {
            doctor = "Fabian Duran";
            lbl10.Text = doctor;
        }

        private void rdio3_CheckedChanged(object sender, EventArgs e)
        {
            doctor = "Pedro Guzman";
            lbl10.Text = doctor;
        }
        private void save_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += txtb1.Text + " indentificado con el numero de " + comboBox1.Text + ": "
                + txtb2.Text + " se le informa que su cita ha sido asignada para la fecha " + lblfecha.Text +
                " con el doctor " + lbl10.Text + ", porfavor estar atento a su correo: " + txtb3.Text +
                ". Su metodo de pago seleccionado fue: " + lbl6.Text + "\n";

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            Report f = new Report();
            f.richTextBox2.Text = richTextBox1.Text;
            this.Hide();
            f.ShowDialog();
        }
    }
}
