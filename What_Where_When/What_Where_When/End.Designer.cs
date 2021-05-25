
namespace What_Where_When
{
    partial class End
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
            this.labelCommunication = new System.Windows.Forms.Label();
            this.richTextBoxScore = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.labelCommunication.Size = new System.Drawing.Size(1525, 71);
            this.labelCommunication.TabIndex = 3;
            this.labelCommunication.Text = "Игра окончена со счетом 0 : 0 в пользу ...";
            this.labelCommunication.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBoxScore
            // 
            this.richTextBoxScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxScore.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxScore.Location = new System.Drawing.Point(12, 74);
            this.richTextBoxScore.Name = "richTextBoxScore";
            this.richTextBoxScore.Size = new System.Drawing.Size(1501, 635);
            this.richTextBoxScore.TabIndex = 5;
            this.richTextBoxScore.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(1218, 744);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(295, 47);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить отчет";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::What_Where_When.Properties.Resources.SplashScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1525, 803);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBoxScore);
            this.Controls.Add(this.labelCommunication);
            this.Name = "End";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.End_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCommunication;
        private System.Windows.Forms.RichTextBox richTextBoxScore;
        private System.Windows.Forms.Button buttonSave;
    }
}