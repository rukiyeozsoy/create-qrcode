namespace QR
{
    partial class QrCode
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            textQR = new System.Windows.Forms.TextBox();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(29, 430);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(457, 476);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = System.Drawing.Color.RosyBrown;
            iconButton8.ForeColor = System.Drawing.Color.White;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton8.IconColor = System.Drawing.Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.Location = new System.Drawing.Point(346, 322);
            iconButton8.Margin = new System.Windows.Forms.Padding(4);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new System.Drawing.Size(140, 42);
            iconButton8.TabIndex = 41;
            iconButton8.Text = "Oluştur";
            iconButton8.UseVisualStyleBackColor = false;
            iconButton8.Click += iconButton8_Click;
            // 
            // textQR
            // 
            textQR.Location = new System.Drawing.Point(31, 265);
            textQR.Margin = new System.Windows.Forms.Padding(0);
            textQR.Name = "textQR";
            textQR.Size = new System.Drawing.Size(455, 31);
            textQR.TabIndex = 39;
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
            iconButton6.TabIndex = 37;
            iconButton6.Text = "Metin Giriniz";
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = System.Drawing.Color.MistyRose;
            iconPictureBox3.ForeColor = System.Drawing.Color.RosyBrown;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.TextHeight;
            iconPictureBox3.IconColor = System.Drawing.Color.RosyBrown;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 101;
            iconPictureBox3.Location = new System.Drawing.Point(29, 72);
            iconPictureBox3.Margin = new System.Windows.Forms.Padding(4);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new System.Drawing.Size(129, 101);
            iconPictureBox3.TabIndex = 36;
            iconPictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            dataGridView1.Location = new System.Drawing.Point(567, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new System.Drawing.Size(645, 667);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // QrCode
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(1834, 979);
            Controls.Add(pictureBox1);
            Controls.Add(iconButton8);
            Controls.Add(textQR);
            Controls.Add(iconButton6);
            Controls.Add(iconPictureBox3);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "QrCode";
            Text = "QR Code";
            Load += QrCode_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.TextBox textQR;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}