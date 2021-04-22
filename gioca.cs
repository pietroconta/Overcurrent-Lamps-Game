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
    public partial class gioca : Form
    {
        public gioca()
        {
            InitializeComponent();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int diff = Form1.diff, row = 0, col = 0;
        Random rnd = new Random();
        Point lastpoint;
        bool stop = false;
        

        private void button1_Click(object sender, EventArgs e)
        {
            tab_data.Visible = true;
            pbl_inizia.Visible = false;

            ordina();
        }

        private void tab_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            

        }

        private void tab_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!stop)
            {
                int rw = e.RowIndex;
                int cm = e.ColumnIndex;

                if (tab_data.Rows[rw].Cells[cm].Style.ForeColor == Color.White)
                    tab_data.Rows[rw].Cells[cm].Style.ForeColor = Color.Yellow;
                else
                    tab_data.Rows[rw].Cells[cm].Style.ForeColor = Color.White;

                if (rw - 1 > -1)
                {
                    if (tab_data.Rows[rw - 1].Cells[cm].Style.ForeColor == Color.White)
                        tab_data.Rows[rw - 1].Cells[cm].Style.ForeColor = Color.Yellow;

                    else
                    {
                        tab_data.Rows[rw - 1].Cells[cm].Style.ForeColor = Color.White;
                    }
                }
                if (rw + 1 < row)
                {
                    if (tab_data.Rows[rw + 1].Cells[cm].Style.ForeColor == Color.White)
                        tab_data.Rows[rw + 1].Cells[cm].Style.ForeColor = Color.Yellow;

                    else
                        tab_data.Rows[rw + 1].Cells[cm].Style.ForeColor = Color.White;
                }

                if (cm + 1 < col)
                {
                    if (tab_data.Rows[rw].Cells[cm + 1].Style.ForeColor == Color.White)
                        tab_data.Rows[rw].Cells[cm + 1].Style.ForeColor = Color.Yellow;

                    else
                        tab_data.Rows[rw].Cells[cm + 1].Style.ForeColor = Color.White;
                }

                if (cm - 1 > -1)
                {

                    if (tab_data.Rows[rw].Cells[cm - 1].Style.ForeColor == Color.White)
                        tab_data.Rows[rw].Cells[cm - 1].Style.ForeColor = Color.Yellow;

                    else
                        tab_data.Rows[rw].Cells[cm - 1].Style.ForeColor = Color.White;

                }

                if (vict())
                {

                    btn_menu.Visible = true;
                    lbl_vittoria.Visible = true;
                    stop = true;
                }
            }
            else {
                Form1 menu = new Form1();
                menu.Show();
                this.Hide();
            }
        }
        public bool vict(bool vit = true) {

            for (int r = 0; r < row; r++) {

                for (int c = 0; c < col; c++) {

                    if (tab_data.Rows[r].Cells[c].Style.ForeColor == Color.White)
                        vit = false;
                    
                        
                    
                    
                
                }
            
            }

            return vit;
        
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {


                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;


            }
        }

        private void gioca_Load(object sender, EventArgs e)
        {
            tab_data.ForeColor = Color.White;
            if (diff == 1)
            {
                tab_data.RowCount = 3;
                tab_data.ColumnCount = 3;

            }

            else if (diff == 2)
            {

                tab_data.RowCount = 5;
                tab_data.ColumnCount = 5;
            }

            else {

                tab_data.RowCount = 9;
                tab_data.ColumnCount = 9;
            }

            row = tab_data.RowCount;
            col = tab_data.ColumnCount;


        }

        private void ordina()
        {
            
                for (int r = 0; r < row; r++)
                {

                    for (int c = 0; c < col; c++)
                    {

                    if (rb_random.Checked)
                    {
                        tab_data.Rows[r].Cells[c].Value = "💡";
                        if (rnd.Next(0, 2) == 1)
                            tab_data.Rows[r].Cells[c].Style.ForeColor = Color.Yellow;
                        else
                            tab_data.Rows[r].Cells[c].Style.ForeColor = Color.White;
                    }

                    else
                    {
                        tab_data.Rows[r].Cells[c].Value = "💡";
                        tab_data.Rows[r].Cells[c].Style.ForeColor = Color.White;
                    }
                    

                        if (diff == 1)
                        {
                            tab_data.Rows[r].Height = 80;
                            tab_data.Columns[c].Width = 80;
                            tab_data.Location = new Point(143, 142);
                            
                        }

                        else if (diff == 2)
                        {
                            tab_data.Rows[r].Height = 60;
                            tab_data.Columns[c].Width = 60;
                        }

                        else {
                            tab_data.Rows[r].Height = 45;
                            tab_data.Columns[c].Width = 45;
                        }


                    


                }
                }
            
        }
    }
}
