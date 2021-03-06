﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Uploader
{
    public partial class Publish : Form
    {
        UploaderCore.UploaderCore WPClient = new UploaderCore.UploaderCore();
        public Publish()
        {
            InitializeComponent();
            InformationIcon.Hide();
            //CheckUserInputs();
        }

        private void UploadButton_Click(object sender, EventArgs e) //When this is clicked, start the upload sequence.
        {
            backgroundUpload.RunWorkerAsync();
        }

        private WordPressSharp.Models.Post GeneratePost()
        {
            WordPressSharp.Models.Post post = new WordPressSharp.Models.Post()  //Create a new post
            {
                Title = Globals.PostTitle,
                Content = GeneratePostContent(),
                ModifiedDateTime = DateTime.Now,
                PublishDateTime = DateTime.Now,
                //TODO: Add terms, and option for live/draft/defered publish
            };
            return post;
        }

        private string GeneratePostContent()
        {
            return @"<div id = ""pdf""><object id = ""pdf_content"" data=""" + Globals.RemoteNewsletterPath + @"?#zoom=85&amp;scrollbar=1&amp;toolbar=1&amp;navpanes=1"" type = ""application/pdf"" width = ""400"" height = ""500""><a href = """ + Globals.RemoteNewsletterPath + @""">Newsletter for the above date </a></object></div>" + Globals.PostBody;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try //If any part of this fails abort it all.
            {
                WPClient.init(BlogUrlBox.Text, WordpressUsernameBox.Text, WordpressPasswordBox.Text);   //Initialise the client
                backgroundUpload.ReportProgress(10);
                Globals.RemoteNewsletterPath = WPClient.UploadLetter(Globals.localNewsletterPath, Path.GetFileName(Globals.localNewsletterPath)); //Upload the Newsletter PDF and get the remote path for it.
                backgroundUpload.ReportProgress(70);
                WPClient.UploadPost(GeneratePost());    //Generate a post based on the entered info and upload it.
                backgroundUpload.ReportProgress(100);
            }
            catch
            {
                backgroundUpload.ReportProgress(100);

            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PublishLog.Clear();
            for(int i = 0; i < WPClient.Log.Count; i++)
            {
                PublishLog.AppendText(WPClient.Log[i] + "\n");
            }
        }
        //private void CheckUserInputs()
        //{
        //    bool UrlOkay, UrlHasHTTP, UsernameOkay, PasswordOkay;
        //    if(BlogUrlBox.Text != "")
        //    {
        //        if (BlogUrlBox.Text.Contains("http://") || BlogUrlBox.Text.Contains("https://"))
        //        {
        //            UrlHasHTTP = true;
        //            UrlOkay = true;
        //        }
        //        else
        //        {
        //            UrlHasHTTP = false;
        //            UrlOkay = false;
        //        }
        //    }
        //    else
        //    {
        //        UrlOkay = false;
        //        UrlHasHTTP = false;
        //    }

        //    if (WordpressUsernameBox.Text != "")
        //    {
        //        UsernameOkay = true;
        //    }
        //    else
        //    {
        //        UsernameOkay = false;
        //    }

        //    if(WordpressPasswordBox.Text != "")
        //    {
        //        PasswordOkay = true;
        //    }
        //    else
        //    {
        //        PasswordOkay = false;
        //    }

        //    if(UrlOkay && UsernameOkay && PasswordOkay)
        //    {
        //        InformationIcon.Hide();
        //        UploadTip.Active = false;
        //        UploadButton.Enabled = true;
        //    }
        //    else
        //    {
        //        InformationIcon.Show();
        //        UploadTip.Active = true;
        //        UploadButton.Enabled = false;
        //        if (!UrlOkay)
        //        {
        //            UploadTip.SetToolTip(this.UploadButton, "Enter the full address of the website (e.g. http://www.example.com)");
        //        }
        //        else if(!UrlHasHTTP)
        //        {
        //            UploadTip.SetToolTip(this.UploadButton, "Ensure the address has \"http://\" or \"https://\" at the front");
        //        }
        //        else if (!UsernameOkay)
        //        {
        //            UploadTip.SetToolTip(this.UploadButton, "Enter your username");
        //        }
        //        else if (!PasswordOkay)
        //        {
        //            UploadTip.SetToolTip(this.UploadButton, "Enter your password");
        //        }
        //    }
        //}

        private void BlogUrlBox_TextChanged(object sender, EventArgs e)
        {
            //CheckUserInputs();
        }

        private void WordpressUsernameBox_TextChanged(object sender, EventArgs e)
        {
            //CheckUserInputs();
        }

        private void WordpressPasswordBox_TextChanged(object sender, EventArgs e)
        {
            //CheckUserInputs();
        }
    }
}
