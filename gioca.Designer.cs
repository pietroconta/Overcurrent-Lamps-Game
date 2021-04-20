
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_close = new System.Windows.Forms.Label();
            this.tab_data = new System.Windows.Forms.DataGridView();
            this.rb_random = new System.Windows.Forms.RadioButton();
            this.rb_normale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pbl_inizia = new System.Windows.Forms.Panel();
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
            this.tab_data.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tab_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tab_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_data.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tab_data.DefaultCellStyle = dataGridViewCellStyle2;
            this.tab_data.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tab_data.Location = new System.Drawing.Point(33, 62);
            this.tab_data.Name = "tab_data";
            this.tab_data.RowHeadersVisible = false;
            this.tab_data.Size = new System.Drawing.Size(457, 445);
            this.tab_data.TabIndex = 4;
            this.tab_data.Visible = false;
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
            // gioca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(515, 563);
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

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.DataGridView tab_data;
        private System.Windows.Forms.RadioButton rb_random;
        private System.Windows.Forms.RadioButton rb_normale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pbl_inizia;
    }
}