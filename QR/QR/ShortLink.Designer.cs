﻿namespace QR
{
    partial class ShortLink
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
            FontAwesome.Sharp.IconButton iconButton6;
            ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            textLink = new System.Windows.Forms.TextBox();
            Linkiniz = new System.Windows.Forms.LinkLabel();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            iconButton6 = new FontAwesome.Sharp.IconButton();
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
            iconButton6.TabIndex = 41;
            iconButton6.Text = "Kısaltmak istediğiniz linki giriniz";
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // ıconPictureBox1
            // 
            ıconPictureBox1.BackColor = System.Drawing.Color.MistyRose;
            ıconPictureBox1.ForeColor = System.Drawing.Color.RosyBrown;
            ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Link;
            ıconPictureBox1.IconColor = System.Drawing.Color.RosyBrown;
            ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox1.IconSize = 101;
            ıconPictureBox1.Location = new System.Drawing.Point(29, 72);
            ıconPictureBox1.Name = "ıconPictureBox1";
            ıconPictureBox1.Size = new System.Drawing.Size(129, 101);
            ıconPictureBox1.TabIndex = 42;
            ıconPictureBox1.TabStop = false;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = System.Drawing.Color.RosyBrown;
            iconButton8.ForeColor = System.Drawing.Color.White;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton8.IconColor = System.Drawing.Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.Location = new System.Drawing.Point(344, 527);
            iconButton8.Margin = new System.Windows.Forms.Padding(4);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new System.Drawing.Size(140, 42);
            iconButton8.TabIndex = 44;
            iconButton8.Text = "Kısalt";
            iconButton8.UseVisualStyleBackColor = false;
            iconButton8.Click += iconButton8_Click;
            // 
            // textLink
            // 
            textLink.Location = new System.Drawing.Point(29, 470);
            textLink.Margin = new System.Windows.Forms.Padding(0);
            textLink.Name = "textLink";
            textLink.Size = new System.Drawing.Size(455, 31);
            textLink.TabIndex = 43;
            // 
            // Linkiniz
            // 
            Linkiniz.AutoSize = true;
            Linkiniz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Linkiniz.Location = new System.Drawing.Point(29, 636);
            Linkiniz.Name = "Linkiniz";
            Linkiniz.Size = new System.Drawing.Size(143, 32);
            Linkiniz.TabIndex = 45;
            Linkiniz.TabStop = true;
            Linkiniz.Tag = "";
            Linkiniz.Text = "Kısa Linkiniz";
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = System.Drawing.Color.RosyBrown;
            ıconButton1.ForeColor = System.Drawing.Color.White;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton1.IconColor = System.Drawing.Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.Location = new System.Drawing.Point(29, 299);
            ıconButton1.Margin = new System.Windows.Forms.Padding(4);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new System.Drawing.Size(140, 42);
            ıconButton1.TabIndex = 47;
            ıconButton1.Text = "Başlık";
            ıconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(173, 305);
            textBox1.Margin = new System.Windows.Forms.Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(311, 31);
            textBox1.TabIndex = 46;
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
            dataGridView1.TabIndex = 48;
            // 
            // ShortLink
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(1834, 979);
            Controls.Add(dataGridView1);
            Controls.Add(ıconButton1);
            Controls.Add(textBox1);
            Controls.Add(Linkiniz);
            Controls.Add(iconButton8);
            Controls.Add(textLink);
            Controls.Add(ıconPictureBox1);
            Controls.Add(iconButton6);
            Name = "ShortLink";
            Padding = new System.Windows.Forms.Padding(3);
            Text = "ShortLink";
            Load += ShortLink_Load;
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.TextBox textLink;
        private System.Windows.Forms.LinkLabel Linkiniz;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}