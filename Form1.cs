using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giocodellelampadine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int diff = 1;
        Point lastpoint;

        private void lbl_1_MouseHover(object sender, EventArgs e)
        {
            lbl_1.ForeColor = Color.Yellow;
            lbl_2.ForeColor = Color.Black;
            lbl_3.ForeColor = Color.Black;

            label4.ForeColor = Color.Yellow;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.White;
        }

        private void lbl_2_MouseHover(object sender, EventArgs e)
        {
            lbl_1.ForeColor = Color.Black;
            lbl_2.ForeColor = Color.Yellow;
            lbl_3.ForeColor = Color.Black;

            label4.ForeColor = Color.White;
            label5.ForeColor = Color.Yellow;
            label7.ForeColor = Color.White;
        }

        private void lbl_3_MouseHover(object sender, EventArgs e)
        {
            lbl_1.ForeColor = Color.Black;
            lbl_2.ForeColor = Color.Black;
            lbl_3.ForeColor = Color.Red;

            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.Red;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            lbl_1.ForeColor = Color.Yellow;
            lbl_2.ForeColor = Color.Black;
            lbl_3.ForeColor = Color.Black;

            label4.ForeColor = Color.Yellow;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.White;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            lbl_1.ForeColor = Color.Black;
            lbl_2.ForeColor = Color.Yellow;
            lbl_3.ForeColor = Color.Black;

            label4.ForeColor = Color.White;
            label5.ForeColor = Color.Yellow;
            label7.ForeColor = Color.White;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            lbl_1.ForeColor = Color.Black;
            lbl_2.ForeColor = Color.Black;
            lbl_3.ForeColor = Color.Red;

            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.Red;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            gioca gioca = new gioca();
            gioca.Show();
            this.Hide();
        }

        private void lbl_1_Click(object sender, EventArgs e)
        {
            gioca gioca = new gioca();
            gioca.Show();
            this.Hide();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            diff = 2;
            label6.ForeColor = Color.Yellow;
            label8.ForeColor = Color.Yellow;
            label9.ForeColor = Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            diff = 1;
            label6.ForeColor = Color.Yellow;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            diff = 3;
            label6.ForeColor = Color.Yellow;
            label8.ForeColor = Color.Yellow;
            label9.ForeColor = Color.Yellow;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {


                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;


            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
