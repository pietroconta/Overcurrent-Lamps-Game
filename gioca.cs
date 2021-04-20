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

        private void button1_Click(object sender, EventArgs e)
        {
            tab_data.Visible = true;
            pbl_inizia.Visible = false;

            ordina();
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
                            tab_data.Rows[r].Cells[c].Value = "💡";
                    

                        if (diff == 1)
                        {
                            tab_data.Rows[r].Height = 80;
                            tab_data.Columns[c].Width = 80;
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
