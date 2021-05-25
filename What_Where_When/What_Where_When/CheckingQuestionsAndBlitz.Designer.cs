
namespace What_Where_When
{
    partial class CheckingQuestionsAndBlitz
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
            this.labelEnteringBlitz = new System.Windows.Forms.Label();
            this.buttonAcceptQuestion = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonSkipCheking = new System.Windows.Forms.Button();
            this.textBoxThemeBlitz = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelEnteringBlitz
            // 
            this.labelEnteringBlitz.BackColor = System.Drawing.Color.Transparent;
            this.labelEnteringBlitz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEnteringBlitz.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnteringBlitz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEnteringBlitz.Location = new System.Drawing.Point(0, 0);
            this.labelEnteringBlitz.Name = "labelEnteringBlitz";
            this.labelEnteringBlitz.Size = new System.Drawing.Size(1494, 1055);
            this.labelEnteringBlitz.TabIndex = 6;
            this.labelEnteringBlitz.Text = "Проверите вопрос № 1";
            this.labelEnteringBlitz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAcceptQuestion
            // 
            this.buttonAcceptQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAcceptQuestion.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAcceptQuestion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAcceptQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcceptQuestion.Location = new System.Drawing.Point(498, 889);
            this.buttonAcceptQuestion.Name = "buttonAcceptQuestion";
            this.buttonAcceptQuestion.Size = new System.Drawing.Size(489, 40);
            this.buttonAcceptQuestion.TabIndex = 11;
            this.buttonAcceptQuestion.TabStop = false;
            this.buttonAcceptQuestion.Text = "Правильно";
            this.buttonAcceptQuestion.UseVisualStyleBackColor = false;
            this.buttonAcceptQuestion.Click += new System.EventHandler(this.buttonAcceptQuestion_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(498, 784);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer.Size = new System.Drawing.Size(489, 99);
            this.textBoxAnswer.TabIndex = 10;
            this.textBoxAnswer.TabStop = false;
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
            this.textBoxQuestion.Location = new System.Drawing.Point(498, 679);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestion.Size = new System.Drawing.Size(489, 99);
            this.textBoxQuestion.TabIndex = 9;
            this.textBoxQuestion.TabStop = false;
            this.textBoxQuestion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxQuestion_KeyUp);
            this.textBoxQuestion.MouseEnter += new System.EventHandler(this.textBoxQuestion_MouseEnter);
            this.textBoxQuestion.MouseLeave += new System.EventHandler(this.textBoxQuestion_MouseLeave);
            this.textBoxQuestion.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxQuestion_PreviewKeyDown);
            // 
            // buttonSkipCheking
            // 
            this.buttonSkipCheking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSkipCheking.BackColor = System.Drawing.Color.Transparent;
            this.buttonSkipCheking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSkipCheking.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSkipCheking.ForeColor = System.Drawing.Color.White;
            this.buttonSkipCheking.Location = new System.Drawing.Point(1167, 12);
            this.buttonSkipCheking.Name = "buttonSkipCheking";
            this.buttonSkipCheking.Size = new System.Drawing.Size(315, 57);
            this.buttonSkipCheking.TabIndex = 12;
            this.buttonSkipCheking.TabStop = false;
            this.buttonSkipCheking.Text = "Пропустить этап проверки";
            this.buttonSkipCheking.UseVisualStyleBackColor = false;
            this.buttonSkipCheking.Click += new System.EventHandler(this.buttonSkipCheking_Click);
            // 
            // textBoxThemeBlitz
            // 
            this.textBoxThemeBlitz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxThemeBlitz.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThemeBlitz.Location = new System.Drawing.Point(498, 370);
            this.textBoxThemeBlitz.Multiline = true;
            this.textBoxThemeBlitz.Name = "textBoxThemeBlitz";
            this.textBoxThemeBlitz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxThemeBlitz.Size = new System.Drawing.Size(489, 99);
            this.textBoxThemeBlitz.TabIndex = 13;
            this.textBoxThemeBlitz.TabStop = false;
            this.textBoxThemeBlitz.Visible = false;
            this.textBoxThemeBlitz.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxThemeBlitz_KeyUp);
            this.textBoxThemeBlitz.MouseEnter += new System.EventHandler(this.textBoxThemeBlitz_MouseEnter);
            this.textBoxThemeBlitz.MouseLeave += new System.EventHandler(this.textBoxThemeBlitz_MouseLeave);
            this.textBoxThemeBlitz.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxThemeBlitz_PreviewKeyDown);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthor.Location = new System.Drawing.Point(498, 574);
            this.textBoxAuthor.Multiline = true;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAuthor.Size = new System.Drawing.Size(489, 99);
            this.textBoxAuthor.TabIndex = 14;
            this.textBoxAuthor.TabStop = false;
            this.textBoxAuthor.Visible = false;
            this.textBoxAuthor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAuthor_KeyUp);
            this.textBoxAuthor.MouseEnter += new System.EventHandler(this.textBoxAuthor_MouseEnter);
            this.textBoxAuthor.MouseLeave += new System.EventHandler(this.textBoxAuthor_MouseLeave);
            this.textBoxAuthor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxAuthor_PreviewKeyDown);
            // 
            // CheckingQuestionsAndBlitz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::What_Where_When.Properties.Resources.SplashScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1494, 1055);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxThemeBlitz);
            this.Controls.Add(this.buttonSkipCheking);
            this.Controls.Add(this.buttonAcceptQuestion);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelEnteringBlitz);
            this.Name = "CheckingQuestionsAndBlitz";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckingQuestionsAndBlitz_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnteringBlitz;
        private System.Windows.Forms.Button buttonAcceptQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonSkipCheking;
        private System.Windows.Forms.TextBox textBoxThemeBlitz;
        private System.Windows.Forms.TextBox textBoxAuthor;
    }
}