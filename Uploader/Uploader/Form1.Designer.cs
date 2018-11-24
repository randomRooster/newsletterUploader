namespace Uploader
{
    partial class MainScreen
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
            this.openNewsletter = new System.Windows.Forms.OpenFileDialog();
            this.FileLocation = new System.Windows.Forms.Label();
            this.FileSelection = new System.Windows.Forms.TextBox();
            this.OpenNavigator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PostTitle = new System.Windows.Forms.TextBox();
            this.PostBody = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PublishButton = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.InfoWarning = new System.Windows.Forms.PictureBox();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // openNewsletter
            // 
            this.openNewsletter.DefaultExt = "*.pdf";
            this.openNewsletter.Filter = "PDF files|*.pdf|All files|*.*";
            this.openNewsletter.FileOk += new System.ComponentModel.CancelEventHandler(this.openNewsletter_FileOk);
            // 
            // FileLocation
            // 
            this.FileLocation.AutoSize = true;
            this.FileLocation.Location = new System.Drawing.Point(12, 9);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(67, 13);
            this.FileLocation.TabIndex = 0;
            this.FileLocation.Text = "File Location";
            // 
            // FileSelection
            // 
            this.FileSelection.AllowDrop = true;
            this.FileSelection.Location = new System.Drawing.Point(12, 25);
            this.FileSelection.Name = "FileSelection";
            this.FileSelection.Size = new System.Drawing.Size(279, 20);
            this.FileSelection.TabIndex = 1;
            this.FileSelection.TextChanged += new System.EventHandler(this.FileSelection_TextChanged);
            // 
            // OpenNavigator
            // 
            this.OpenNavigator.Location = new System.Drawing.Point(297, 23);
            this.OpenNavigator.Name = "OpenNavigator";
            this.OpenNavigator.Size = new System.Drawing.Size(41, 23);
            this.OpenNavigator.TabIndex = 2;
            this.OpenNavigator.Text = "Open";
            this.OpenNavigator.UseVisualStyleBackColor = true;
            this.OpenNavigator.Click += new System.EventHandler(this.OpenNavigator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Post Title";
            // 
            // PostTitle
            // 
            this.PostTitle.Location = new System.Drawing.Point(12, 64);
            this.PostTitle.Name = "PostTitle";
            this.PostTitle.Size = new System.Drawing.Size(279, 20);
            this.PostTitle.TabIndex = 4;
            this.PostTitle.TextChanged += new System.EventHandler(this.PostTitle_TextChanged);
            // 
            // PostBody
            // 
            this.PostBody.Location = new System.Drawing.Point(12, 115);
            this.PostBody.Name = "PostBody";
            this.PostBody.Size = new System.Drawing.Size(317, 104);
            this.PostBody.TabIndex = 5;
            this.PostBody.Text = "";
            this.PostBody.TextChanged += new System.EventHandler(this.PostBody_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Post Body";
            // 
            // PublishButton
            // 
            this.PublishButton.Location = new System.Drawing.Point(3, 3);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(75, 23);
            this.PublishButton.TabIndex = 7;
            this.PublishButton.Text = "Publish";
            this.PublishButton.UseVisualStyleBackColor = true;
            this.PublishButton.Click += new System.EventHandler(this.Publish_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.PublishButton);
            this.ButtonPanel.Location = new System.Drawing.Point(258, 222);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(80, 29);
            this.ButtonPanel.TabIndex = 8;
            // 
            // InfoWarning
            // 
            this.InfoWarning.Image = global::Uploader.Properties.Resources.Info16;
            this.InfoWarning.Location = new System.Drawing.Point(239, 235);
            this.InfoWarning.Name = "InfoWarning";
            this.InfoWarning.Size = new System.Drawing.Size(16, 16);
            this.InfoWarning.TabIndex = 9;
            this.InfoWarning.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 263);
            this.Controls.Add(this.InfoWarning);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PostBody);
            this.Controls.Add(this.PostTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenNavigator);
            this.Controls.Add(this.FileSelection);
            this.Controls.Add(this.FileLocation);
            this.Name = "MainScreen";
            this.Text = "Newsletter Uploader";
            this.Load += new System.EventHandler(this.MainScreenLoad);
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openNewsletter;
        private System.Windows.Forms.Label FileLocation;
        private System.Windows.Forms.Button OpenNavigator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PublishButton;
        public System.Windows.Forms.TextBox FileSelection;
        public System.Windows.Forms.TextBox PostTitle;
        public System.Windows.Forms.RichTextBox PostBody;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.PictureBox InfoWarning;
    }
}

