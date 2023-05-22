namespace QR
{
    partial class Analiz
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
            components = new System.ComponentModel.Container();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // iconButton6
            // 
            iconButton6.BackColor = System.Drawing.Color.RosyBrown;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.ForeColor = System.Drawing.Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton6.IconColor = System.Drawing.SystemColors.Window;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.Location = new System.Drawing.Point(166, 86);
            iconButton6.Margin = new System.Windows.Forms.Padding(4);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new System.Drawing.Size(320, 72);
            iconButton6.TabIndex = 39;
            iconButton6.Text = "Analiz Sonuçları";
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // ıconPictureBox1
            // 
            ıconPictureBox1.BackColor = System.Drawing.Color.MistyRose;
            ıconPictureBox1.ForeColor = System.Drawing.Color.RosyBrown;
            ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            ıconPictureBox1.IconColor = System.Drawing.Color.RosyBrown;
            ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox1.IconSize = 101;
            ıconPictureBox1.Location = new System.Drawing.Point(29, 72);
            ıconPictureBox1.Name = "ıconPictureBox1";
            ıconPictureBox1.Size = new System.Drawing.Size(129, 101);
            ıconPictureBox1.TabIndex = 40;
            ıconPictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            dataGridView1.Location = new System.Drawing.Point(29, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(1438, 658);
            dataGridView1.TabIndex = 0;
            // 
            // Analiz
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(1834, 979);
            Controls.Add(ıconPictureBox1);
            Controls.Add(iconButton6);
            Controls.Add(dataGridView1);
            Name = "Analiz";
            Text = "Analiz";
            Load += Analiz_Load;
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}