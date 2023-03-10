namespace ProjectGameMVC
{
    partial class LeaderForm
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
            this.dgvHighScore = new System.Windows.Forms.DataGridView();
            this.TopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLeaderBoard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBackLoginForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScore)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHighScore
            // 
            this.dgvHighScore.AllowUserToAddRows = false;
            this.dgvHighScore.AllowUserToDeleteRows = false;
            this.dgvHighScore.AllowUserToResizeColumns = false;
            this.dgvHighScore.AllowUserToResizeRows = false;
            this.dgvHighScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHighScore.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dgvHighScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHighScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvHighScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TopColumn,
            this.UserNameColumn,
            this.ScoreCollumn});
            this.dgvHighScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHighScore.GridColor = System.Drawing.Color.SaddleBrown;
            this.dgvHighScore.Location = new System.Drawing.Point(0, 0);
            this.dgvHighScore.Name = "dgvHighScore";
            this.dgvHighScore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHighScore.Size = new System.Drawing.Size(834, 402);
            this.dgvHighScore.TabIndex = 0;
            this.dgvHighScore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHighScore_CellContentClick);
            // 
            // TopColumn
            // 
            this.TopColumn.HeaderText = "Top";
            this.TopColumn.Name = "TopColumn";
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.HeaderText = "User Name";
            this.UserNameColumn.Name = "UserNameColumn";
            // 
            // ScoreCollumn
            // 
            this.ScoreCollumn.HeaderText = "Max Score";
            this.ScoreCollumn.Name = "ScoreCollumn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.btnBackLoginForm);
            this.panel1.Controls.Add(this.lbLeaderBoard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 452);
            this.panel1.TabIndex = 1;
            // 
            // lbLeaderBoard
            // 
            this.lbLeaderBoard.AutoSize = true;
            this.lbLeaderBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeaderBoard.ForeColor = System.Drawing.Color.Black;
            this.lbLeaderBoard.Location = new System.Drawing.Point(314, 9);
            this.lbLeaderBoard.Name = "lbLeaderBoard";
            this.lbLeaderBoard.Size = new System.Drawing.Size(169, 33);
            this.lbLeaderBoard.TabIndex = 2;
            this.lbLeaderBoard.Text = "Top Server";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHighScore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 402);
            this.panel2.TabIndex = 1;
            // 
            // btnBackLoginForm
            // 
            this.btnBackLoginForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBackLoginForm.BackgroundImage = global::ProjectGameMVC.Properties.Resources.back;
            this.btnBackLoginForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackLoginForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBackLoginForm.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBackLoginForm.Location = new System.Drawing.Point(0, 3);
            this.btnBackLoginForm.Name = "btnBackLoginForm";
            this.btnBackLoginForm.Size = new System.Drawing.Size(57, 53);
            this.btnBackLoginForm.TabIndex = 24;
            this.btnBackLoginForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackLoginForm.UseVisualStyleBackColor = false;
            this.btnBackLoginForm.Click += new System.EventHandler(this.btnBackLoginForm_Click);
            // 
            // LeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 452);
            this.Controls.Add(this.panel1);
            this.Name = "LeaderForm";
            this.Text = "LeaderForm";
            this.Load += new System.EventHandler(this.LeaderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLeaderBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreCollumn;
        private System.Windows.Forms.Button btnBackLoginForm;
    }
}