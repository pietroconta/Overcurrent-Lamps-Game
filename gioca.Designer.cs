
namespace giocodellelampadine
{
    partial class gioca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_close = new System.Windows.Forms.Label();
            this.tab_data = new System.Windows.Forms.DataGridView();
            this.rb_random = new System.Windows.Forms.RadioButton();
            this.rb_normale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pbl_inizia = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.lbl_vittoria = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_data)).BeginInit();
            this.pbl_inizia.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.lbl_close);
            this.panel1.Location = new System.Drawing.Point(-9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 20);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_close.Location = new System.Drawing.Point(504, 2);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(17, 18);
            this.lbl_close.TabIndex = 5;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // tab_data
            // 
            this.tab_data.AllowUserToAddRows = false;
            this.tab_data.AllowUserToDeleteRows = false;
            this.tab_data.AllowUserToOrderColumns = true;
            this.tab_data.AllowUserToResizeColumns = false;
            this.tab_data.AllowUserToResizeRows = false;
            this.tab_data.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tab_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tab_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_data.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tab_data.DefaultCellStyle = dataGridViewCellStyle5;
            this.tab_data.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tab_data.Location = new System.Drawing.Point(33, 62);
            this.tab_data.Name = "tab_data";
            this.tab_data.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.tab_data.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tab_data.Size = new System.Drawing.Size(457, 445);
            this.tab_data.TabIndex = 4;
            this.tab_data.Visible = false;
            this.tab_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tab_data_CellClick);
            this.tab_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tab_data_CellContentClick);
            // 
            // rb_random
            // 
            this.rb_random.AutoSize = true;
            this.rb_random.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_random.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_random.Location = new System.Drawing.Point(12, 45);
            this.rb_random.Name = "rb_random";
            this.rb_random.Size = new System.Drawing.Size(212, 40);
            this.rb_random.TabIndex = 5;
            this.rb_random.TabStop = true;
            this.rb_random.Text = "Tabella Random";
            this.rb_random.UseVisualStyleBackColor = true;
            // 
            // rb_normale
            // 
            this.rb_normale.AutoSize = true;
            this.rb_normale.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_normale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_normale.Location = new System.Drawing.Point(12, 14);
            this.rb_normale.Name = "rb_normale";
            this.rb_normale.Size = new System.Drawing.Size(128, 40);
            this.rb_normale.TabIndex = 6;
            this.rb_normale.TabStop = true;
            this.rb_normale.Text = "Normale";
            this.rb_normale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inizia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbl_inizia
            // 
            this.pbl_inizia.Controls.Add(this.rb_normale);
            this.pbl_inizia.Controls.Add(this.button1);
            this.pbl_inizia.Controls.Add(this.rb_random);
            this.pbl_inizia.Location = new System.Drawing.Point(143, 184);
            this.pbl_inizia.Name = "pbl_inizia";
            this.pbl_inizia.Size = new System.Drawing.Size(229, 161);
            this.pbl_inizia.TabIndex = 8;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Yellow;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(428, 534);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 28);
            this.btn_menu.TabIndex = 8;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Visible = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // lbl_vittoria
            // 
            this.lbl_vittoria.AutoSize = true;
            this.lbl_vittoria.Font = new System.Drawing.Font("Monotype Corsiva", 45F, System.Drawing.FontStyle.Italic);
            this.lbl_vittoria.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_vittoria.Location = new System.Drawing.Point(131, 498);
            this.lbl_vittoria.Name = "lbl_vittoria";
            this.lbl_vittoria.Size = new System.Drawing.Size(285, 72);
            this.lbl_vittoria.TabIndex = 8;
            this.lbl_vittoria.Text = "Hai vinto!!!";
            this.lbl_vittoria.Visible = false;
            // 
            // gioca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(515, 577);
            this.Controls.Add(this.lbl_vittoria);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.pbl_inizia);
            this.Controls.Add(this.tab_data);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gioca";
            this.Text = "gioca";
            this.Load += new System.EventHandler(this.gioca_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_data)).EndInit();
            this.pbl_inizia.ResumeLayout(false);
            this.pbl_inizia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.DataGridView tab_data;
        private System.Windows.Forms.RadioButton rb_random;
        private System.Windows.Forms.RadioButton rb_normale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pbl_inizia;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label lbl_vittoria;
    }
}