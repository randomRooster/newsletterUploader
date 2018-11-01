using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uploader
{
    public partial class MainScreen : Form
    {
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


        //Because I have no idea how to access these from another class
        private void FileSelection_TextChanged(object sender, EventArgs e)
        {
            Globals.localNewsletterPath = FileSelection.Text;
        }
        private void PostTitle_TextChanged(object sender, EventArgs e)
        {
            Globals.PostTitle = PostTitle.Text;
        }
        private void PostBody_TextChanged(object sender, EventArgs e)
        {
            Globals.PostBody = PostBody.Text;
        }

        private void MainScreenLoad(object sender, EventArgs e)
        {
            //Create tooltip
            ToolTip PublishTip = new ToolTip();

            //Set up delays
        }
    }
}
