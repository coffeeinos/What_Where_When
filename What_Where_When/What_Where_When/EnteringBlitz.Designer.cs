
namespace What_Where_When
{
    partial class EnteringBlitz
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
            this.labelEnteringQuestions = new System.Windows.Forms.Label();
            this.buttonEndEnter = new System.Windows.Forms.Button();
            this.buttonEnterQuestion = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.labelEnteringBlitz = new System.Windows.Forms.Label();
            this.buttonEnterBlitz = new System.Windows.Forms.Button();
            this.buttonEnterBlitzTheme = new System.Windows.Forms.Button();
            this.textBoxBlitzTheme = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelEnteringQuestions
            // 
            this.labelEnteringQuestions.BackColor = System.Drawing.Color.Transparent;
            this.labelEnteringQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEnteringQuestions.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnteringQuestions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEnteringQuestions.Location = new System.Drawing.Point(0, 0);
            this.labelEnteringQuestions.Name = "labelEnteringQuestions";
            this.labelEnteringQuestions.Size = new System.Drawing.Size(1499, 987);
            this.labelEnteringQuestions.TabIndex = 1;
            this.labelEnteringQuestions.Text = "Введите блиц № 1";
            this.labelEnteringQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEndEnter
            // 
            this.buttonEndEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEndEnter.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEndEnter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEndEnter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndEnter.Location = new System.Drawing.Point(533, 859);
            this.buttonEndEnter.Name = "buttonEndEnter";
            this.buttonEndEnter.Size = new System.Drawing.Size(427, 40);
            this.buttonEndEnter.TabIndex = 9;
            this.buttonEndEnter.TabStop = false;
            this.buttonEndEnter.Text = "Завершить ввод блицов";
            this.buttonEndEnter.UseVisualStyleBackColor = false;
            this.buttonEndEnter.Visible = false;
            this.buttonEndEnter.Click += new System.EventHandler(this.buttonEndEnter_Click);
            // 
            // buttonEnterQuestion
            // 
            this.buttonEnterQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnterQuestion.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEnterQuestion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEnterQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterQuestion.Location = new System.Drawing.Point(533, 767);
            this.buttonEnterQuestion.Name = "buttonEnterQuestion";
            this.buttonEnterQuestion.Size = new System.Drawing.Size(427, 40);
            this.buttonEnterQuestion.TabIndex = 8;
            this.buttonEnterQuestion.TabStop = false;
            this.buttonEnterQuestion.Text = "Принять вопрос № 1 для блица";
            this.buttonEnterQuestion.UseVisualStyleBackColor = false;
            this.buttonEnterQuestion.Visible = false;
            this.buttonEnterQuestion.Click += new System.EventHandler(this.buttonEnterQuestion_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(533, 662);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer.Size = new System.Drawing.Size(427, 99);
            this.textBoxAnswer.TabIndex = 7;
            this.textBoxAnswer.TabStop = false;
            this.textBoxAnswer.Text = "Введите ответ";
            this.textBoxAnswer.Visible = false;
            this.textBoxAnswer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswer_KeyUp);
            this.textBoxAnswer.MouseEnter += new System.EventHandler(this.textBoxAnswer_MouseEnter);
            this.textBoxAnswer.MouseLeave += new System.EventHandler(this.textBoxAnswer_MouseLeave);
            this.textBoxAnswer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxAnswer_PreviewKeyDown);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(533, 557);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestion.Size = new System.Drawing.Size(427, 99);
            this.textBoxQuestion.TabIndex = 6;
            this.textBoxQuestion.TabStop = false;
            this.textBoxQuestion.Text = "Введите вопрос";
            this.textBoxQuestion.Visible = false;
            this.textBoxQuestion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxQuestion_KeyUp);
            this.textBoxQuestion.MouseEnter += new System.EventHandler(this.textBoxQuestion_MouseEnter);
            this.textBoxQuestion.MouseLeave += new System.EventHandler(this.textBoxQuestion_MouseLeave);
            this.textBoxQuestion.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxQuestion_PreviewKeyDown);
            // 
            // labelEnteringBlitz
            // 
            this.labelEnteringBlitz.BackColor = System.Drawing.Color.Transparent;
            this.labelEnteringBlitz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEnteringBlitz.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnteringBlitz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEnteringBlitz.Location = new System.Drawing.Point(0, 0);
            this.labelEnteringBlitz.Name = "labelEnteringBlitz";
            this.labelEnteringBlitz.Size = new System.Drawing.Size(1499, 987);
            this.labelEnteringBlitz.TabIndex = 5;
            this.labelEnteringBlitz.Text = "Введите блиц № 1";
            this.labelEnteringBlitz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEnterBlitz
            // 
            this.buttonEnterBlitz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnterBlitz.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEnterBlitz.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEnterBlitz.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterBlitz.Location = new System.Drawing.Point(533, 813);
            this.buttonEnterBlitz.Name = "buttonEnterBlitz";
            this.buttonEnterBlitz.Size = new System.Drawing.Size(427, 40);
            this.buttonEnterBlitz.TabIndex = 10;
            this.buttonEnterBlitz.TabStop = false;
            this.buttonEnterBlitz.Text = "Принять блиц № 1";
            this.buttonEnterBlitz.UseVisualStyleBackColor = false;
            this.buttonEnterBlitz.Visible = false;
            this.buttonEnterBlitz.Click += new System.EventHandler(this.buttonEnterBlitz_Click);
            // 
            // buttonEnterBlitzTheme
            // 
            this.buttonEnterBlitzTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnterBlitzTheme.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEnterBlitzTheme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEnterBlitzTheme.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterBlitzTheme.Location = new System.Drawing.Point(533, 416);
            this.buttonEnterBlitzTheme.Name = "buttonEnterBlitzTheme";
            this.buttonEnterBlitzTheme.Size = new System.Drawing.Size(427, 40);
            this.buttonEnterBlitzTheme.TabIndex = 12;
            this.buttonEnterBlitzTheme.TabStop = false;
            this.buttonEnterBlitzTheme.Text = "Принять тему для блица № 1";
            this.buttonEnterBlitzTheme.UseVisualStyleBackColor = false;
            this.buttonEnterBlitzTheme.Click += new System.EventHandler(this.buttonEnterBlitzTheme_Click);
            // 
            // textBoxBlitzTheme
            // 
            this.textBoxBlitzTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBlitzTheme.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlitzTheme.Location = new System.Drawing.Point(533, 311);
            this.textBoxBlitzTheme.Multiline = true;
            this.textBoxBlitzTheme.Name = "textBoxBlitzTheme";
            this.textBoxBlitzTheme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBlitzTheme.Size = new System.Drawing.Size(427, 99);
            this.textBoxBlitzTheme.TabIndex = 11;
            this.textBoxBlitzTheme.TabStop = false;
            this.textBoxBlitzTheme.Text = "Введите тему блица";
            this.textBoxBlitzTheme.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBlitzTheme_KeyUp);
            this.textBoxBlitzTheme.MouseEnter += new System.EventHandler(this.textBoxBlitzTheme_MouseEnter);
            this.textBoxBlitzTheme.MouseLeave += new System.EventHandler(this.textBoxBlitzTheme_MouseLeave);
            this.textBoxBlitzTheme.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxBlitzTheme_PreviewKeyDown);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthor.Location = new System.Drawing.Point(533, 206);
            this.textBoxAuthor.Multiline = true;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAuthor.Size = new System.Drawing.Size(427, 99);
            this.textBoxAuthor.TabIndex = 13;
            this.textBoxAuthor.TabStop = false;
            this.textBoxAuthor.Text = "Введите автора блица";
            this.textBoxAuthor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAuthor_KeyUp);
            this.textBoxAuthor.MouseEnter += new System.EventHandler(this.textBoxAuthor_MouseEnter);
            this.textBoxAuthor.MouseLeave += new System.EventHandler(this.textBoxAuthor_MouseLeave);
            this.textBoxAuthor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxAuthor_PreviewKeyDown);
            // 
            // EnteringBlitz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::What_Where_When.Properties.Resources.SplashScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1499, 987);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.buttonEnterBlitzTheme);
            this.Controls.Add(this.textBoxBlitzTheme);
            this.Controls.Add(this.buttonEnterBlitz);
            this.Controls.Add(this.buttonEndEnter);
            this.Controls.Add(this.buttonEnterQuestion);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelEnteringBlitz);
            this.Controls.Add(this.labelEnteringQuestions);
            this.Name = "EnteringBlitz";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnteringBlitz_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnteringQuestions;
        private System.Windows.Forms.Button buttonEndEnter;
        private System.Windows.Forms.Button buttonEnterQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label labelEnteringBlitz;
        private System.Windows.Forms.Button buttonEnterBlitz;
        private System.Windows.Forms.Button buttonEnterBlitzTheme;
        private System.Windows.Forms.TextBox textBoxBlitzTheme;
        private System.Windows.Forms.TextBox textBoxAuthor;
    }
}