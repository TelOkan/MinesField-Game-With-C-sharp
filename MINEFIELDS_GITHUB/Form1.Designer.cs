
namespace MINEFIELDS_GITHUB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_level3 = new System.Windows.Forms.PictureBox();
            this.pb_level2 = new System.Windows.Forms.PictureBox();
            this.pb_level1 = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_number_of_mines = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_level3 = new System.Windows.Forms.Label();
            this.lbl_level2 = new System.Windows.Forms.Label();
            this.lbl_level1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_level3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_level2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_level1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_level3
            // 
            this.pb_level3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_level3.Location = new System.Drawing.Point(770, 65);
            this.pb_level3.Name = "pb_level3";
            this.pb_level3.Size = new System.Drawing.Size(64, 64);
            this.pb_level3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_level3.TabIndex = 24;
            this.pb_level3.TabStop = false;
            this.pb_level3.Click += new System.EventHandler(this.pb_level3_Click);
            // 
            // pb_level2
            // 
            this.pb_level2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_level2.Location = new System.Drawing.Point(700, 65);
            this.pb_level2.Name = "pb_level2";
            this.pb_level2.Size = new System.Drawing.Size(64, 64);
            this.pb_level2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_level2.TabIndex = 25;
            this.pb_level2.TabStop = false;
            this.pb_level2.Click += new System.EventHandler(this.pb_level2_Click);
            // 
            // pb_level1
            // 
            this.pb_level1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_level1.Location = new System.Drawing.Point(630, 65);
            this.pb_level1.Name = "pb_level1";
            this.pb_level1.Size = new System.Drawing.Size(64, 64);
            this.pb_level1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_level1.TabIndex = 26;
            this.pb_level1.TabStop = false;
            this.pb_level1.Click += new System.EventHandler(this.pb_level1_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_score.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Green;
            this.lbl_score.Location = new System.Drawing.Point(321, 114);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(79, 43);
            this.lbl_score.TabIndex = 20;
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_number_of_mines
            // 
            this.lbl_number_of_mines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_number_of_mines.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_number_of_mines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_number_of_mines.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number_of_mines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_number_of_mines.Location = new System.Drawing.Point(321, 65);
            this.lbl_number_of_mines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_number_of_mines.Name = "lbl_number_of_mines";
            this.lbl_number_of_mines.Size = new System.Drawing.Size(79, 43);
            this.lbl_number_of_mines.TabIndex = 21;
            this.lbl_number_of_mines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_play
            // 
            this.btn_play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_play.AutoEllipsis = true;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.Location = new System.Drawing.Point(434, 14);
            this.btn_play.Margin = new System.Windows.Forms.Padding(4);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(189, 145);
            this.btn_play.TabIndex = 19;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(226, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Of mines";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(226, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number";
            // 
            // lbl_level3
            // 
            this.lbl_level3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_level3.AutoSize = true;
            this.lbl_level3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_level3.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_level3.Location = new System.Drawing.Point(784, 121);
            this.lbl_level3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_level3.Name = "lbl_level3";
            this.lbl_level3.Size = new System.Drawing.Size(37, 39);
            this.lbl_level3.TabIndex = 14;
            this.lbl_level3.Text = "3";
            // 
            // lbl_level2
            // 
            this.lbl_level2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_level2.AutoSize = true;
            this.lbl_level2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_level2.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_level2.Location = new System.Drawing.Point(714, 121);
            this.lbl_level2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_level2.Name = "lbl_level2";
            this.lbl_level2.Size = new System.Drawing.Size(37, 39);
            this.lbl_level2.TabIndex = 15;
            this.lbl_level2.Text = "2";
            // 
            // lbl_level1
            // 
            this.lbl_level1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_level1.AutoSize = true;
            this.lbl_level1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_level1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_level1.Location = new System.Drawing.Point(644, 121);
            this.lbl_level1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_level1.Name = "lbl_level1";
            this.lbl_level1.Size = new System.Drawing.Size(37, 39);
            this.lbl_level1.TabIndex = 16;
            this.lbl_level1.Text = "1";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(634, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Select Your LeveL!";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(226, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Score";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(222, 166);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 571);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(779, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Location = new System.Drawing.Point(77, 131);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(697, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Firstly";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1045, 750);
            this.Controls.Add(this.pb_level3);
            this.Controls.Add(this.pb_level2);
            this.Controls.Add(this.pb_level1);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_number_of_mines);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_level3);
            this.Controls.Add(this.lbl_level2);
            this.Controls.Add(this.lbl_level1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MINESFIELD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_level3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_level2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_level1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_level3;
        private System.Windows.Forms.PictureBox pb_level2;
        private System.Windows.Forms.PictureBox pb_level1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_number_of_mines;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_level3;
        private System.Windows.Forms.Label lbl_level2;
        private System.Windows.Forms.Label lbl_level1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

