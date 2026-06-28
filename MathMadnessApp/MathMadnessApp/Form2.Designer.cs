namespace MathMadnessApp
{
    partial class Form2
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
            tblMain = new TableLayoutPanel();
            tblAnswers = new TableLayoutPanel();
            lblAnswers = new Label();
            btnA1 = new Button();
            btnA2 = new Button();
            btnA3 = new Button();
            btnA4 = new Button();
            btnA5 = new Button();
            btnA6 = new Button();
            btnA7 = new Button();
            btnA8 = new Button();
            tblQuestions = new TableLayoutPanel();
            lblQuestions = new Label();
            btnQ1 = new Button();
            btnQ2 = new Button();
            btnQ3 = new Button();
            btnQ4 = new Button();
            btnQ5 = new Button();
            btnQ6 = new Button();
            btnQ7 = new Button();
            btnQ8 = new Button();
            tblToolbar = new TableLayoutPanel();
            btnNewTurn = new Button();
            btnStart = new Button();
            lblPlayer1 = new Label();
            lblPlayer2 = new Label();
            tblMain.SuspendLayout();
            tblAnswers.SuspendLayout();
            tblQuestions.SuspendLayout();
            tblToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(tblAnswers, 1, 1);
            tblMain.Controls.Add(tblQuestions, 0, 1);
            tblMain.Controls.Add(tblToolbar, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75994F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 81.24007F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(904, 666);
            tblMain.TabIndex = 1;
            // 
            // tblAnswers
            // 
            tblAnswers.ColumnCount = 2;
            tblAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAnswers.Controls.Add(lblAnswers, 0, 0);
            tblAnswers.Controls.Add(btnA1, 0, 1);
            tblAnswers.Controls.Add(btnA2, 1, 1);
            tblAnswers.Controls.Add(btnA3, 0, 2);
            tblAnswers.Controls.Add(btnA4, 1, 2);
            tblAnswers.Controls.Add(btnA5, 0, 3);
            tblAnswers.Controls.Add(btnA6, 1, 3);
            tblAnswers.Controls.Add(btnA7, 0, 4);
            tblAnswers.Controls.Add(btnA8, 1, 4);
            tblAnswers.Dock = DockStyle.Fill;
            tblAnswers.Location = new Point(455, 129);
            tblAnswers.Name = "tblAnswers";
            tblAnswers.RowCount = 5;
            tblAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblAnswers.Size = new Size(445, 533);
            tblAnswers.TabIndex = 2;
            // 
            // lblAnswers
            // 
            tblAnswers.SetColumnSpan(lblAnswers, 2);
            lblAnswers.Dock = DockStyle.Fill;
            lblAnswers.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswers.Location = new Point(3, 0);
            lblAnswers.Name = "lblAnswers";
            lblAnswers.Size = new Size(439, 106);
            lblAnswers.TabIndex = 0;
            lblAnswers.Text = "Answers";
            lblAnswers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnA1
            // 
            btnA1.Dock = DockStyle.Fill;
            btnA1.Enabled = false;
            btnA1.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnA1.Location = new Point(3, 109);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(216, 100);
            btnA1.TabIndex = 1;
            btnA1.Text = "!";
            btnA1.UseVisualStyleBackColor = true;
            // 
            // btnA2
            // 
            btnA2.Dock = DockStyle.Fill;
            btnA2.Enabled = false;
            btnA2.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnA2.Location = new Point(225, 109);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(217, 100);
            btnA2.TabIndex = 2;
            btnA2.Text = "!";
            btnA2.UseVisualStyleBackColor = true;
            // 
            // btnA3
            // 
            btnA3.Dock = DockStyle.Fill;
            btnA3.Enabled = false;
            btnA3.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnA3.Location = new Point(3, 215);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(216, 100);
            btnA3.TabIndex = 3;
            btnA3.Text = "!";
            btnA3.UseVisualStyleBackColor = true;
            // 
            // btnA4
            // 
            btnA4.Dock = DockStyle.Fill;
            btnA4.Enabled = false;
            btnA4.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnA4.Location = new Point(225, 215);
            btnA4.Name = "btnA4";
            btnA4.Size = new Size(217, 100);
            btnA4.TabIndex = 4;
            btnA4.Text = "!";
            btnA4.UseVisualStyleBackColor = true;
            // 
            // btnA5
            // 
            btnA5.Dock = DockStyle.Fill;
            btnA5.Enabled = false;
            btnA5.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnA5.Location = new Point(3, 321);
            btnA5.Name = "btnA5";
            btnA5.Size = new Size(216, 100);
            btnA5.TabIndex = 5;
            btnA5.Text = "!";
            btnA5.UseVisualStyleBackColor = true;
            // 
            // btnA6
            // 
            btnA6.Dock = DockStyle.Fill;
            btnA6.Enabled = false;
            btnA6.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnA6.Location = new Point(225, 321);
            btnA6.Name = "btnA6";
            btnA6.Size = new Size(217, 100);
            btnA6.TabIndex = 6;
            btnA6.Text = "!";
            btnA6.UseVisualStyleBackColor = true;
            // 
            // btnA7
            // 
            btnA7.Dock = DockStyle.Fill;
            btnA7.Enabled = false;
            btnA7.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnA7.Location = new Point(3, 427);
            btnA7.Name = "btnA7";
            btnA7.Size = new Size(216, 103);
            btnA7.TabIndex = 7;
            btnA7.Text = "!";
            btnA7.UseVisualStyleBackColor = true;
            // 
            // btnA8
            // 
            btnA8.Dock = DockStyle.Fill;
            btnA8.Enabled = false;
            btnA8.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnA8.Location = new Point(225, 427);
            btnA8.Name = "btnA8";
            btnA8.Size = new Size(217, 103);
            btnA8.TabIndex = 8;
            btnA8.Text = "!";
            btnA8.UseVisualStyleBackColor = true;
            // 
            // tblQuestions
            // 
            tblQuestions.ColumnCount = 2;
            tblQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblQuestions.Controls.Add(lblQuestions, 0, 0);
            tblQuestions.Controls.Add(btnQ1, 0, 1);
            tblQuestions.Controls.Add(btnQ2, 1, 1);
            tblQuestions.Controls.Add(btnQ3, 0, 2);
            tblQuestions.Controls.Add(btnQ4, 1, 2);
            tblQuestions.Controls.Add(btnQ5, 0, 3);
            tblQuestions.Controls.Add(btnQ6, 1, 3);
            tblQuestions.Controls.Add(btnQ7, 0, 4);
            tblQuestions.Controls.Add(btnQ8, 1, 4);
            tblQuestions.Dock = DockStyle.Fill;
            tblQuestions.Location = new Point(4, 129);
            tblQuestions.Name = "tblQuestions";
            tblQuestions.RowCount = 5;
            tblQuestions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblQuestions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblQuestions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblQuestions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblQuestions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblQuestions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblQuestions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblQuestions.Size = new Size(444, 533);
            tblQuestions.TabIndex = 1;
            // 
            // lblQuestions
            // 
            tblQuestions.SetColumnSpan(lblQuestions, 2);
            lblQuestions.Dock = DockStyle.Fill;
            lblQuestions.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestions.Location = new Point(3, 0);
            lblQuestions.Name = "lblQuestions";
            lblQuestions.Size = new Size(438, 106);
            lblQuestions.TabIndex = 0;
            lblQuestions.Text = "Questions";
            lblQuestions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnQ1
            // 
            btnQ1.Dock = DockStyle.Fill;
            btnQ1.Enabled = false;
            btnQ1.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ1.Location = new Point(3, 109);
            btnQ1.Name = "btnQ1";
            btnQ1.Size = new Size(216, 100);
            btnQ1.TabIndex = 1;
            btnQ1.Text = "?";
            btnQ1.UseVisualStyleBackColor = true;
            // 
            // btnQ2
            // 
            btnQ2.Dock = DockStyle.Fill;
            btnQ2.Enabled = false;
            btnQ2.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ2.Location = new Point(225, 109);
            btnQ2.Name = "btnQ2";
            btnQ2.Size = new Size(216, 100);
            btnQ2.TabIndex = 2;
            btnQ2.Text = "?";
            btnQ2.UseVisualStyleBackColor = true;
            // 
            // btnQ3
            // 
            btnQ3.Dock = DockStyle.Fill;
            btnQ3.Enabled = false;
            btnQ3.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ3.Location = new Point(3, 215);
            btnQ3.Name = "btnQ3";
            btnQ3.Size = new Size(216, 100);
            btnQ3.TabIndex = 3;
            btnQ3.Text = "?";
            btnQ3.UseVisualStyleBackColor = true;
            // 
            // btnQ4
            // 
            btnQ4.Dock = DockStyle.Fill;
            btnQ4.Enabled = false;
            btnQ4.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ4.Location = new Point(225, 215);
            btnQ4.Name = "btnQ4";
            btnQ4.Size = new Size(216, 100);
            btnQ4.TabIndex = 4;
            btnQ4.Text = "?";
            btnQ4.UseVisualStyleBackColor = true;
            // 
            // btnQ5
            // 
            btnQ5.Dock = DockStyle.Fill;
            btnQ5.Enabled = false;
            btnQ5.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ5.Location = new Point(3, 321);
            btnQ5.Name = "btnQ5";
            btnQ5.Size = new Size(216, 100);
            btnQ5.TabIndex = 5;
            btnQ5.Text = "?";
            btnQ5.UseVisualStyleBackColor = true;
            // 
            // btnQ6
            // 
            btnQ6.Dock = DockStyle.Fill;
            btnQ6.Enabled = false;
            btnQ6.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ6.Location = new Point(225, 321);
            btnQ6.Name = "btnQ6";
            btnQ6.Size = new Size(216, 100);
            btnQ6.TabIndex = 6;
            btnQ6.Text = "?";
            btnQ6.UseVisualStyleBackColor = true;
            // 
            // btnQ7
            // 
            btnQ7.Dock = DockStyle.Fill;
            btnQ7.Enabled = false;
            btnQ7.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ7.Location = new Point(3, 427);
            btnQ7.Name = "btnQ7";
            btnQ7.Size = new Size(216, 103);
            btnQ7.TabIndex = 7;
            btnQ7.Text = "?";
            btnQ7.UseVisualStyleBackColor = true;
            // 
            // btnQ8
            // 
            btnQ8.Dock = DockStyle.Fill;
            btnQ8.Enabled = false;
            btnQ8.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ8.Location = new Point(225, 427);
            btnQ8.Name = "btnQ8";
            btnQ8.Size = new Size(216, 103);
            btnQ8.TabIndex = 8;
            btnQ8.Text = "?";
            btnQ8.UseVisualStyleBackColor = true;
            // 
            // tblToolbar
            // 
            tblToolbar.ColumnCount = 4;
            tblMain.SetColumnSpan(tblToolbar, 2);
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblToolbar.Controls.Add(btnNewTurn, 1, 0);
            tblToolbar.Controls.Add(btnStart, 0, 0);
            tblToolbar.Controls.Add(lblPlayer1, 2, 0);
            tblToolbar.Controls.Add(lblPlayer2, 3, 0);
            tblToolbar.Dock = DockStyle.Fill;
            tblToolbar.Location = new Point(4, 4);
            tblToolbar.Name = "tblToolbar";
            tblToolbar.RowCount = 1;
            tblToolbar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblToolbar.Size = new Size(896, 118);
            tblToolbar.TabIndex = 3;
            // 
            // btnNewTurn
            // 
            btnNewTurn.Anchor = AnchorStyles.Bottom;
            btnNewTurn.Location = new Point(263, 46);
            btnNewTurn.Name = "btnNewTurn";
            btnNewTurn.Size = new Size(146, 69);
            btnNewTurn.TabIndex = 1;
            btnNewTurn.Text = "New Turn";
            btnNewTurn.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom;
            btnStart.Location = new Point(39, 46);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(146, 69);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // lblPlayer1
            // 
            lblPlayer1.Anchor = AnchorStyles.None;
            lblPlayer1.BackColor = Color.White;
            lblPlayer1.Location = new Point(493, 29);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(134, 60);
            lblPlayer1.TabIndex = 2;
            lblPlayer1.Text = "Player 1:";
            lblPlayer1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayer2
            // 
            lblPlayer2.Anchor = AnchorStyles.None;
            lblPlayer2.BackColor = Color.White;
            lblPlayer2.Location = new Point(717, 29);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(134, 60);
            lblPlayer2.TabIndex = 3;
            lblPlayer2.Text = "Player 2:";
            lblPlayer2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 666);
            Controls.Add(tblMain);
            Name = "Form2";
            Text = "Form2";
            tblMain.ResumeLayout(false);
            tblAnswers.ResumeLayout(false);
            tblQuestions.ResumeLayout(false);
            tblToolbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblAnswers;
        private Label lblAnswers;
        private Button btnA1;
        private Button btnA2;
        private Button btnA3;
        private Button btnA4;
        private Button btnA5;
        private Button btnA6;
        private Button btnA7;
        private Button btnA8;
        private TableLayoutPanel tblQuestions;
        private Label lblQuestions;
        private Button btnQ1;
        private Button btnQ2;
        private Button btnQ3;
        private Button btnQ4;
        private Button btnQ5;
        private Button btnQ6;
        private Button btnQ7;
        private Button btnQ8;
        private TableLayoutPanel tblToolbar;
        private Button btnNewTurn;
        private Button btnStart;
        private Label lblPlayer1;
        private Label lblPlayer2;
    }
}