namespace QR
{
    partial class AnaSayfa
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
            ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ıconPictureBox1
            // 
            ıconPictureBox1.BackColor = System.Drawing.Color.MistyRose;
            ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox1.IconSize = 8;
            ıconPictureBox1.Location = new System.Drawing.Point(545, 291);
            ıconPictureBox1.Name = "ıconPictureBox1";
            ıconPictureBox1.Size = new System.Drawing.Size(8, 8);
            ıconPictureBox1.TabIndex = 12;
            ıconPictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image1;
            pictureBox2.Location = new System.Drawing.Point(451, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(401, 399);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.RosyBrown;
            label1.Location = new System.Drawing.Point(417, 627);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(464, 32);
            label1.TabIndex = 15;
            label1.Text = "Hızlı QR kod oluşturma ve link kısaltma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.RosyBrown;
            label2.Location = new System.Drawing.Point(247, 655);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(923, 32);
            label2.TabIndex = 16;
            label2.Text = "deneyimi sunan kullanıcı dostu bir uygulama ile link paylaşımınızı kolaylaştırın!";
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(1834, 979);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(ıconPictureBox1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "AnaSayfa";
            Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}