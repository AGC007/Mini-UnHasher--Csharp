using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSuite;
using System.Net;
using System.Text.RegularExpressions;
using Json;

namespace Hash_Decrypter_V1
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }
        private void BTN_FIND_Click(object sender, EventArgs e)//Find :|
        {   
            //TXT_LED.Visible = false; TXT_LED.Visible = true;
            TXT_LED.Text = "....";
            TXT_LED.TextColor = Color.WhiteSmoke;
                              
            string HASH = TXT_HASH.Text;
            WebClient FindHash = new WebClient();
            string Address = $"http://www.nitrxgen.net/md5db/{HASH}.json";
            FindHash.Headers[HttpRequestHeader.ContentType] = "application/json";
            //FindHash.Headers[HttpRequestHeader.Host] = "bluecode.info";
            FindHash.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
            string Respone = FindHash.DownloadString(Address);
            dynamic Json_API = JsonParser.FromJson(Respone);
            TXT_LED.Text = "....";

            //keyCheck
            if (Respone.Contains("found\":true"))
            {
                TXT_LED.Visible = false; TXT_LED.Visible = true;

                //Match FindHashR = Regex.Match(Respone, $"\"ok\":true,\"private\":false,\"{HASH}\":\"(.*?)\"");
                string UnHsah = Json_API["result"]["pass"];
                /////
                TXT_LED.TextColor = Color.LightGreen;
                TXT_LED.Text = $"Found :)" + @"
" + @"Result : " + UnHsah;
               }
           else
            { TXT_LED.Visible = false; TXT_LED.Visible = true; TXT_LED.TextColor = Color.OrangeRed; TXT_LED.Text = "Not Found :("; }    
     }
        private void Home_Load(object sender, EventArgs e)//Form Load :)
        {TXT_LED.Text = "Enter Your Hash And Click The Find Button :)";}

        //AGC007 2021 ©
    }
}
