
namespace What_Where_When
{
    partial class StartGame
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
            this.buttonQuestion = new System.Windows.Forms.Button();
            this.buttonBlitz = new System.Windows.Forms.Button();
            this.labelCommunication = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxThemeBlitz = new System.Windows.Forms.TextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonWrong = new System.Windows.Forms.Button();
            this.textBoxNameOfResponder = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonQuestion
            // 
            this.buttonQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonQuestion.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuestion.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonQuestion.Location = new System.Drawing.Point(12, 714);
            this.buttonQuestion.Name = "buttonQuestion";
            this.buttonQuestion.Size = new System.Drawing.Size(388, 75);
            this.buttonQuestion.TabIndex = 0;
            this.buttonQuestion.Text = "Обычный вопрос";
            this.buttonQuestion.UseVisualStyleBackColor = false;
            this.buttonQuestion.Click += new System.EventHandler(this.buttonQuestion_Click);
            // 
            // buttonBlitz
            // 
            this.buttonBlitz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBlitz.BackColor = System.Drawing.Color.Transparent;
            this.buttonBlitz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBlitz.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlitz.ForeColor = System.Drawing.Color.White;
            this.buttonBlitz.Location = new System.Drawing.Point(1190, 714);
            this.buttonBlitz.Name = "buttonBlitz";
            this.buttonBlitz.Size = new System.Drawing.Size(295, 75);
            this.buttonBlitz.TabIndex = 1;
            this.buttonBlitz.Text = "Блиц";
            this.buttonBlitz.UseVisualStyleBackColor = false;
            this.buttonBlitz.Click += new System.EventHandler(this.buttonBlitz_Click);
            // 
            // labelCommunication
            // 
            this.labelCommunication.BackColor = System.Drawing.Color.Transparent;
            this.labelCommunication.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCommunication.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommunication.ForeColor = System.Drawing.Color.White;
            this.labelCommunication.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCommunication.Location = new System.Drawing.Point(0, 0);
            this.labelCommunication.Name = "labelCommunication";
            this.labelCommunication.Size = new System.Drawing.Size(1497, 71);
            this.labelCommunication.TabIndex = 2;
            this.labelCommunication.Text = "Выберите раунд";
            this.labelCommunication.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthor.Location = new System.Drawing.Point(496, 238);
            this.textBoxAuthor.Multiline = true;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAuthor.Size = new System.Drawing.Size(489, 99);
            this.textBoxAuthor.TabIndex = 18;
            this.textBoxAuthor.TabStop = false;
            this.textBoxAuthor.Visible = false;
            // 
            // textBoxThemeBlitz
            // 
            this.textBoxThemeBlitz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxThemeBlitz.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThemeBlitz.Location = new System.Drawing.Point(496, 133);
            this.textBoxThemeBlitz.Multiline = true;
            this.textBoxThemeBlitz.Name = "textBoxThemeBlitz";
            this.textBoxThemeBlitz.ReadOnly = true;
            this.textBoxThemeBlitz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxThemeBlitz.Size = new System.Drawing.Size(489, 99);
            this.textBoxThemeBlitz.TabIndex = 17;
            this.textBoxThemeBlitz.TabStop = false;
            this.textBoxThemeBlitz.Visible = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(496, 448);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer.Size = new System.Drawing.Size(489, 99);
            this.textBoxAnswer.TabIndex = 16;
            this.textBoxAnswer.TabStop = false;
            this.textBoxAnswer.Visible = false;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(496, 343);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestion.Size = new System.Drawing.Size(489, 99);
            this.textBoxQuestion.TabIndex = 15;
            this.textBoxQuestion.TabStop = false;
            this.textBoxQuestion.Visible = false;
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.SystemColors.Info;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRight.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(496, 597);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(244, 40);
            this.buttonRight.TabIndex = 19;
            this.buttonRight.TabStop = false;
            this.buttonRight.Text = "Правильно";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Visible = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonWrong
            // 
            this.buttonWrong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWrong.BackColor = System.Drawing.SystemColors.Info;
            this.buttonWrong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonWrong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWrong.Location = new System.Drawing.Point(741, 597);
            this.buttonWrong.Name = "buttonWrong";
            this.buttonWrong.Size = new System.Drawing.Size(244, 40);
            this.buttonWrong.TabIndex = 20;
            this.buttonWrong.TabStop = false;
            this.buttonWrong.Text = "Неправильно";
            this.buttonWrong.UseVisualStyleBackColor = false;
            this.buttonWrong.Visible = false;
            this.buttonWrong.Click += new System.EventHandler(this.buttonWrong_Click);
            // 
            // textBoxNameOfResponder
            // 
            this.textBoxNameOfResponder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameOfResponder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameOfResponder.Location = new System.Drawing.Point(496, 553);
            this.textBoxNameOfResponder.Name = "textBoxNameOfResponder";
            this.textBoxNameOfResponder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNameOfResponder.Size = new System.Drawing.Size(489, 38);
            this.textBoxNameOfResponder.TabIndex = 21;
            this.textBoxNameOfResponder.TabStop = false;
            this.textBoxNameOfResponder.Text = "Введите имя отвечающего";
            this.textBoxNameOfResponder.Visible = false;
            this.textBoxNameOfResponder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNameOfResponder_KeyUp);
            this.textBoxNameOfResponder.MouseEnter += new System.EventHandler(this.textBoxNameOfResponder_MouseEnter);
            this.textBoxNameOfResponder.MouseLeave += new System.EventHandler(this.textBoxNameOfResponder_MouseLeave);
            this.textBoxNameOfResponder.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxNameOfResponder_PreviewKeyDown);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelScore.Location = new System.Drawing.Point(406, 714);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(778, 75);
            this.labelScore.TabIndex = 22;
            this.labelScore.Text = "ЗНАТОКИ 0 : 0 ЗРИТЕЛИ";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::What_Where_When.Properties.Resources.SplashScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1497, 801);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxNameOfResponder);
            this.Controls.Add(this.buttonWrong);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxThemeBlitz);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelCommunication);
            this.Controls.Add(this.buttonBlitz);
            this.Controls.Add(this.buttonQuestion);
            this.Name = "StartGame";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartGame_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuestion;
        private System.Windows.Forms.Button buttonBlitz;
        private System.Windows.Forms.Label labelCommunication;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxThemeBlitz;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonWrong;
        private System.Windows.Forms.TextBox textBoxNameOfResponder;
        private System.Windows.Forms.Label labelScore;
    }
}