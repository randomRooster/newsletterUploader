using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressSharp;
using System.IO;

namespace UploaderCore
{
    class UploaderCore
    {
        public List<string> Log = new List<string>();
        private static WordPressClient Client;
        public bool init(string url, string userLogin, string password, int blogId) //Initiallises the client
        {
            WordPressSiteConfig Config = new WordPressSiteConfig()  //Config the client
            {
                BaseUrl = url,
                Username = userLogin,
                Password = password,
                BlogId = blogId,
            };
            Client = new WordPressClient(Config);
            Log.Add("Wordpress Client initialised.");
            return VerifyClient();  //Check if the Client is functional
        }
        public void init(string url, string userLogin, string password) //If BlogID is not specified, assume 1
        {
            init(url, userLogin, password, 1);  //Assume BlogID is 1
        }
        private bool VerifyClient()
        {
            Log.Add("WARNING: Client verification has not been performed. Will assume URL and Credentials are correct.");
            //TODO: Find a way how to verify that the Client is functional.
            return true;
        }
        public void UploadPost(WordPressSharp.Models.Post post) //Wrapper for uploading
        {
            Log.Add("Uploading Post...");
            try
            {
                Client.NewPost(post);   //Publish the preconfigured post
                Log.Add("Post uploaded!");
            }
            catch (Exception e)
            {
                Log.Add("Post upload failed! \n" + e.Message);
                throw e;
            }
        }
        public string UploadLetter(string localPath, string name)  //Assumes that the file is a PDF. Returns the remote path of the pdf
        {
            byte[] FileBuffer;
            WordPressSharp.Models.Data UploadData;
            WordPressSharp.Models.UploadResult UploadLog;

            if (!File.Exists(localPath)) //Check if the file exists
            {
                Log.Add("File not found! Cannot continue.");
                throw new FileNotFoundException("The selected file does not exist", localPath); //If the file doesn't exist, panic
            }

            FileBuffer = File.ReadAllBytes(localPath);  //Reads the file into a buffer
            Log.Add("File loaded");
            UploadData = new WordPressSharp.Models.Data()   //Prepares the file for upload
            {
                Name = name,
                Bits = FileBuffer,
                Type = "application/pdf",
            };

            Log.Add("Uploading file...");
            try
            {
                UploadLog = Client.UploadFile(UploadData);    //Punts the file at the site and gets the results
                Log.Add("File uploaded!");
            }
            catch (Exception e)
            {
                Log.Add("File upload failed! \n" + e.Message);
                throw e;
            }

            return UploadLog.Url; //Return where to find the file on the website
        }
    }
}
