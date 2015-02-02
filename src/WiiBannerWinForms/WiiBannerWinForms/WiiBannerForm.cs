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

namespace WiiBannerWinForms
{
    public partial class WiiBannerForm : Form
    {
        public WiiBannerForm()
        {
            InitializeComponent();
        }

        private void LoadBannersButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Path.GetDirectoryName(@"C:\Work\gitroot\dolphin\WiiBanner\games\");

            DialogResult result = fbd.ShowDialog();

            string[] folders = Directory.GetDirectories(fbd.SelectedPath);

            foreach (var folder in folders)
            {
                DirectoryInfo di = new DirectoryInfo(folder);

                switch (di.Name)
                {
                    case "SMNP01":
                        BannersListBox.Items.Add(di.Name);

                        var location = "files/EU/save_banner.arc";

                        ExtractARC(folder + location, "./banners/"+di.Name);



                        break;

                    case "STUPRN":
                        BannersListBox.Items.Add(di.Name);

                        break;

                    default:
                        BannersListBox.Items.Add("Do not have banner config for game:" + di.Name);
                        break;
                }
            }
        }

        private void ExtractARC(string arcPath, string savePath)
        {
            //"wszst.ext extract %path%"

            // move contents
        }

        private void CallWiimmsSZSTool()
        {

        }


        private void ConvertTPLToPNG(string tplPath, string pngPath)
        {

        }

        private void ConvertBTIToPNG(string btiPath, string pngBath)
        {
            // wimgt.exe decode btipath 
            // will do decoding in the path .png
        }

        private void CallWiimmsImageTool(string decodePath)
        {

        }
    }
}
