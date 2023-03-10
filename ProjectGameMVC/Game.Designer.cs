namespace ProjectGameMVC
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBoss = new System.Windows.Forms.Panel();
            this.panelHealth = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNameBoss = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHero = new System.Windows.Forms.Panel();
            this.btnMoreQues = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbAnswerTrue = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbCountNumberQuestion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHeroName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBoss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelHero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(0, -3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(786, 704);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelBoss
            // 
            this.panelBoss.BackColor = System.Drawing.Color.Transparent;
            this.panelBoss.Controls.Add(this.panelHealth);
            this.panelBoss.Controls.Add(this.label1);
            this.panelBoss.Controls.Add(this.lbNameBoss);
            this.panelBoss.Controls.Add(this.pictureBox2);
            this.panelBoss.Location = new System.Drawing.Point(784, 312);
            this.panelBoss.Name = "panelBoss";
            this.panelBoss.Size = new System.Drawing.Size(357, 389);
            this.panelBoss.TabIndex = 20;
            // 
            // panelHealth
            // 
            this.panelHealth.BackColor = System.Drawing.Color.Transparent;
            this.panelHealth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHealth.BackgroundImage")));
            this.panelHealth.ForeColor = System.Drawing.Color.Red;
            this.panelHealth.Location = new System.Drawing.Point(157, 93);
            this.panelHealth.Name = "panelHealth";
            this.panelHealth.Size = new System.Drawing.Size(186, 17);
            this.panelHealth.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Health";
            // 
            // lbNameBoss
            // 
            this.lbNameBoss.AutoSize = true;
            this.lbNameBoss.BackColor = System.Drawing.Color.Transparent;
            this.lbNameBoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNameBoss.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameBoss.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbNameBoss.Location = new System.Drawing.Point(3, 46);
            this.lbNameBoss.Name = "lbNameBoss";
            this.lbNameBoss.Size = new System.Drawing.Size(51, 27);
            this.lbNameBoss.TabIndex = 15;
            this.lbNameBoss.Text = "Boss";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panelHero
            // 
            this.panelHero.BackColor = System.Drawing.Color.Transparent;
            this.panelHero.Controls.Add(this.btnMoreQues);
            this.panelHero.Controls.Add(this.label5);
            this.panelHero.Controls.Add(this.lbSec);
            this.panelHero.Controls.Add(this.lbMin);
            this.panelHero.Controls.Add(this.lbTime);
            this.panelHero.Controls.Add(this.lbAnswerTrue);
            this.panelHero.Controls.Add(this.lbScore);
            this.panelHero.Controls.Add(this.lbCountNumberQuestion);
            this.panelHero.Controls.Add(this.pictureBox1);
            this.panelHero.Controls.Add(this.lbHeroName);
            this.panelHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHero.Location = new System.Drawing.Point(784, -3);
            this.panelHero.Name = "panelHero";
            this.panelHero.Size = new System.Drawing.Size(357, 319);
            this.panelHero.TabIndex = 19;
            // 
            // btnMoreQues
            // 
            this.btnMoreQues.BackColor = System.Drawing.Color.Transparent;
            this.btnMoreQues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoreQues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreQues.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMoreQues.Location = new System.Drawing.Point(153, 121);
            this.btnMoreQues.Name = "btnMoreQues";
            this.btnMoreQues.Size = new System.Drawing.Size(134, 31);
            this.btnMoreQues.TabIndex = 24;
            this.btnMoreQues.Text = "MoreQuestion";
            this.btnMoreQues.UseVisualStyleBackColor = false;
            this.btnMoreQues.Click += new System.EventHandler(this.btnMoreQues_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = ":";
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec.Location = new System.Drawing.Point(250, 100);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(18, 24);
            this.lbSec.TabIndex = 20;
            this.lbSec.Text = "0";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(209, 100);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(18, 24);
            this.lbMin.TabIndex = 19;
            this.lbMin.Text = "0";
            this.lbMin.Click += new System.EventHandler(this.lbMin_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(155, 102);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(48, 24);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "Time:";
            // 
            // lbAnswerTrue
            // 
            this.lbAnswerTrue.AutoSize = true;
            this.lbAnswerTrue.BackColor = System.Drawing.Color.Transparent;
            this.lbAnswerTrue.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswerTrue.Location = new System.Drawing.Point(153, 54);
            this.lbAnswerTrue.Name = "lbAnswerTrue";
            this.lbAnswerTrue.Size = new System.Drawing.Size(94, 24);
            this.lbAnswerTrue.TabIndex = 10;
            this.lbAnswerTrue.Text = "AnswerTrue:";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(153, 78);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(50, 24);
            this.lbScore.TabIndex = 9;
            this.lbScore.Text = "Score:";
            // 
            // lbCountNumberQuestion
            // 
            this.lbCountNumberQuestion.AutoSize = true;
            this.lbCountNumberQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbCountNumberQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCountNumberQuestion.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountNumberQuestion.Location = new System.Drawing.Point(153, 30);
            this.lbCountNumberQuestion.Name = "lbCountNumberQuestion";
            this.lbCountNumberQuestion.Size = new System.Drawing.Size(71, 24);
            this.lbCountNumberQuestion.TabIndex = 8;
            this.lbCountNumberQuestion.Text = "Question:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbHeroName
            // 
            this.lbHeroName.AutoSize = true;
            this.lbHeroName.BackColor = System.Drawing.Color.Transparent;
            this.lbHeroName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHeroName.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeroName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbHeroName.Location = new System.Drawing.Point(6, 9);
            this.lbHeroName.Name = "lbHeroName";
            this.lbHeroName.Size = new System.Drawing.Size(52, 27);
            this.lbHeroName.TabIndex = 6;
            this.lbHeroName.Text = "Hero";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 713);
            this.Controls.Add(this.panelBoss);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHero);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.panelBoss.ResumeLayout(false);
            this.panelBoss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelHero.ResumeLayout(false);
            this.panelHero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBoss;
        private System.Windows.Forms.Panel panelHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNameBoss;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelHero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbAnswerTrue;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbCountNumberQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHeroName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMoreQues;
    }
}