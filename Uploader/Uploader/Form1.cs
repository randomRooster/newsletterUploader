using System;
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
    public partial class MainScreen : Form
    {
        private ToolTip PublishTip;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void OpenNavigator_Click(object sender, EventArgs e)    //Open the file selector
        {
            openNewsletter.ShowDialog();
        }

        private void openNewsletter_FileOk(object sender, CancelEventArgs e)    //Put the file name into the text box
        {
            FileSelection.Text = openNewsletter.FileName;
        }

        private void Publish_Click(object sender, EventArgs e)
        {
            Publish publish = new Publish();
            publish.Show();
        }


        //Because I have no idea how to access these from another class, they all sync to a Global
        private void FileSelection_TextChanged(object sender, EventArgs e)
        {
            Globals.localNewsletterPath = FileSelection.Text;
            CheckUserInputs();
        }
        private void PostTitle_TextChanged(object sender, EventArgs e)
        {
            Globals.PostTitle = PostTitle.Text;
            CheckUserInputs();
        }
        private void PostBody_TextChanged(object sender, EventArgs e)
        {
            Globals.PostBody = PostBody.Text;
        }
        private void CheckUserInputs()  //Makes sure that all the required fields are filled before the user can publish
        {
            bool ValidPath = false;
            bool ValidTitle = false;

            if(Path.GetExtension(FileSelection.Text) == ".pdf")
            {
                ValidPath = true;
            }
            else
            {
                ValidPath = false;
            }
            if(PostTitle.Text != "")
            {
                ValidTitle = true;
            }
            else
            {
                ValidTitle = false;
            }

            if(ValidPath)
            {
                if(ValidTitle)
                {
                    PublishTip.Active = false;
                    PublishButton.Enabled = true;
                    InfoWarning.Hide();
                }
                else if(!ValidTitle)
                {
                    PublishTip.Active = true;
                    PublishButton.Enabled = false;
                    InfoWarning.Show();
                    PublishTip.SetToolTip(this.InfoWarning, "Add a title before publishing");
                }
            }
            else if(!ValidPath)
            {
                if (ValidTitle)
                {
                    PublishTip.Active = true;
                    PublishButton.Enabled = false;
                    InfoWarning.Show();
                    PublishTip.SetToolTip(this.InfoWarning, "Select a file before publishing");
                }
                else if (!ValidTitle)
                {
                    PublishTip.Active = true;
                    PublishButton.Enabled = false;
                    InfoWarning.Show();
                    PublishTip.SetToolTip(this.InfoWarning, "Select a file and add a title before publishing");
                }
            }
        }

        private void MainScreenLoad(object sender, EventArgs e)
        {
            //TODO: Load config

            //Create tooltip
            PublishTip = new ToolTip();

            // Set up the delays for the ToolTip.
            PublishTip.AutoPopDelay = 5000;
            PublishTip.InitialDelay = 0;
            PublishTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            PublishTip.ShowAlways = true;

            //Verify the loaded config
            CheckUserInputs();
        }
    }
}
