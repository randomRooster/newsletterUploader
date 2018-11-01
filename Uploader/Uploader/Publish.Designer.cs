namespace Uploader
{
    partial class Publish
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
            this.PublishLog = new System.Windows.Forms.RichTextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.BlogUrlLabel = new System.Windows.Forms.Label();
            this.BlogUrlBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.WordpressUsernameBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.WordpressPasswordBox = new System.Windows.Forms.TextBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.backgroundUpload = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // PublishLog
            // 
            this.PublishLog.Location = new System.Drawing.Point(12, 25);
            this.PublishLog.Name = "PublishLog";
            this.PublishLog.ReadOnly = true;
            this.PublishLog.Size = new System.Drawing.Size(251, 80);
            this.PublishLog.TabIndex = 0;
            this.PublishLog.Text = "";
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(12, 9);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(25, 13);
            this.LogLabel.TabIndex = 1;
            this.LogLabel.Text = "Log";
            // 
            // BlogUrlLabel
            // 
            this.BlogUrlLabel.AutoSize = true;
            this.BlogUrlLabel.Location = new System.Drawing.Point(12, 108);
            this.BlogUrlLabel.Name = "BlogUrlLabel";
            this.BlogUrlLabel.Size = new System.Drawing.Size(107, 13);
            this.BlogUrlLabel.TabIndex = 2;
            this.BlogUrlLabel.Text = "Wordpress Blog URL";
            // 
            // BlogUrlBox
            // 
            this.BlogUrlBox.Location = new System.Drawing.Point(12, 125);
            this.BlogUrlBox.Name = "BlogUrlBox";
            this.BlogUrlBox.Size = new System.Drawing.Size(251, 20);
            this.BlogUrlBox.TabIndex = 3;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(12, 148);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(109, 13);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Wordpress Username";
            // 
            // WordpressUsernameBox
            // 
            this.WordpressUsernameBox.Location = new System.Drawing.Point(12, 165);
            this.WordpressUsernameBox.Name = "WordpressUsernameBox";
            this.WordpressUsernameBox.Size = new System.Drawing.Size(251, 20);
            this.WordpressUsernameBox.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(12, 188);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(107, 13);
            this.Password.TabIndex = 6;
            this.Password.Text = "Wordpress Password";
            // 
            // WordpressPasswordBox
            // 
            this.WordpressPasswordBox.Location = new System.Drawing.Point(12, 205);
            this.WordpressPasswordBox.Name = "WordpressPasswordBox";
            this.WordpressPasswordBox.PasswordChar = '•';
            this.WordpressPasswordBox.Size = new System.Drawing.Size(251, 20);
            this.WordpressPasswordBox.TabIndex = 7;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(188, 231);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 8;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // backgroundUpload
            // 
            this.backgroundUpload.WorkerReportsProgress = true;
            this.backgroundUpload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundUpload.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Publish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 262);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.WordpressPasswordBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.WordpressUsernameBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.BlogUrlBox);
            this.Controls.Add(this.BlogUrlLabel);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.PublishLog);
            this.Name = "Publish";
            this.Text = "Publish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PublishLog;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label BlogUrlLabel;
        private System.Windows.Forms.TextBox BlogUrlBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox WordpressUsernameBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox WordpressPasswordBox;
        private System.Windows.Forms.Button UploadButton;
        private System.ComponentModel.BackgroundWorker backgroundUpload;
    }
}