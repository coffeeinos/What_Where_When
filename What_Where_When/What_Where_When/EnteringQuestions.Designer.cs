
namespace What_Where_When
{
    partial class EnteringQuestions
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
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonEndEnter = new System.Windows.Forms.Button();
            this.textBoxNameAuthor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelEnteringQuestions
            // 
            this.labelEnteringQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEnteringQuestions.BackColor = System.Drawing.Color.Transparent;
            this.labelEnteringQuestions.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnteringQuestions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEnteringQuestions.Location = new System.Drawing.Point(0, 0);
            this.labelEnteringQuestions.Name = "labelEnteringQuestions";
            this.labelEnteringQuestions.Size = new System.Drawing.Size(1499, 801);
            this.labelEnteringQuestions.TabIndex = 0;
            this.labelEnteringQuestions.Text = "Введите вопрос № 1";
            this.labelEnteringQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(532, 664);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestion.Size = new System.Drawing.Size(427, 99);
            this.textBoxQuestion.TabIndex = 1;
            this.textBoxQuestion.TabStop = false;
            this.textBoxQuestion.Text = "Введите вопрос";
            this.textBoxQuestion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxQuestion_KeyUp);
            this.textBoxQuestion.MouseEnter += new System.EventHandler(this.textBoxQuestion_MouseEnter);
            this.textBoxQuestion.MouseLeave += new System.EventHandler(this.textBoxQuestion_MouseLeave);
            this.textBoxQuestion.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxQuestion_PreviewKeyDown);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(532, 769);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer.Size = new System.Drawing.Size(427, 99);
            this.textBoxAnswer.TabIndex = 2;
            this.textBoxAnswer.TabStop = false;
            this.textBoxAnswer.Text = "Введите ответ";
            this.textBoxAnswer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswer_KeyUp);
            this.textBoxAnswer.MouseEnter += new System.EventHandler(this.textBoxAnswer_MouseEnter);
            this.textBoxAnswer.MouseLeave += new System.EventHandler(this.textBoxAnswer_MouseLeave);
            this.textBoxAnswer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxAnswer_PreviewKeyDown);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnter.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEnter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(532, 874);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(427, 40);
            this.buttonEnter.TabIndex = 3;
            this.buttonEnter.TabStop = false;
            this.buttonEnter.Text = "Принять вопрос № 1";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonEndEnter
            // 
            this.buttonEndEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEndEnter.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEndEnter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEndEnter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndEnter.Location = new System.Drawing.Point(532, 920);
            this.buttonEndEnter.Name = "buttonEndEnter";
            this.buttonEndEnter.Size = new System.Drawing.Size(427, 40);
            this.buttonEndEnter.TabIndex = 4;
            this.buttonEndEnter.TabStop = false;
            this.buttonEndEnter.Text = "Завершить ввод вопросов";
            this.buttonEndEnter.UseVisualStyleBackColor = false;
            this.buttonEndEnter.Visible = false;
            this.buttonEndEnter.Click += new System.EventHandler(this.buttonEndEnter_Click);
            // 
            // textBoxNameAuthor
            // 
            this.textBoxNameAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameAuthor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameAuthor.Location = new System.Drawing.Point(532, 559);
            this.textBoxNameAuthor.Multiline = true;
            this.textBoxNameAuthor.Name = "textBoxNameAuthor";
            this.textBoxNameAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNameAuthor.Size = new System.Drawing.Size(427, 99);
            this.textBoxNameAuthor.TabIndex = 5;
            this.textBoxNameAuthor.TabStop = false;
            this.textBoxNameAuthor.Text = "Введите имя автора";
            this.textBoxNameAuthor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNameAuthor_KeyUp);
            this.textBoxNameAuthor.MouseEnter += new System.EventHandler(this.textBoxNameAuthor_MouseEnter);
            this.textBoxNameAuthor.MouseLeave += new System.EventHandler(this.textBoxNameAuthor_MouseLeave);
            this.textBoxNameAuthor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxNameAuthor_PreviewKeyDown);
            // 
            // EnteringQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::What_Where_When.Properties.Resources.SplashScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1499, 1055);
            this.Controls.Add(this.textBoxNameAuthor);
            this.Controls.Add(this.buttonEndEnter);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelEnteringQuestions);
            this.Name = "EnteringQuestions";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnteringQuestions_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnteringQuestions;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonEndEnter;
        private System.Windows.Forms.TextBox textBoxNameAuthor;
    }
}