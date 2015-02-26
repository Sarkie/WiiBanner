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

        private string _gamesPath = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), @"..\..\..\..\..\games\");
        private string _toolsPath = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), @"..\..\..\..\..\tools\");
        private string _bannersPath = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), @"..\..\..\..\..\banners\");

        private void LoadBannersButton_Click(object sender, EventArgs e)
        {
            string[] folders = Directory.GetDirectories(_gamesPath);

            foreach (var folder in folders)
            {
                DirectoryInfo di = new DirectoryInfo(folder);

                var filePath = _bannersPath + di.Name + ".png";

                if (File.Exists(filePath))
                    File.Delete(filePath);

                var lst = new ListViewItem();

                switch (di.Name)
                {
                    case "SMNP01":


                        var location = "/files/EU/save_banner.arc";

                        Extract(folder + location);

                        DecodeImage(folder + "/files/EU/save_banner.d/save_banner_EU.bti");


                        File.Move(folder + "/files/EU/save_banner.d/save_banner_EU.bti.png", _bannersPath + di.Name + ".png");

                        BannerImageList.Images.Add(Image.FromFile(_bannersPath + di.Name + ".png"));


                        lst.Text = di.Name;
                        lst.ImageIndex = BannerImageList.Images.Count - 1;
                        BannersListView.Items.Add(lst);

                        break;

                    case "STUPRN":

                        DecodeImage(folder + "/DATA/files/banner.tpl");

                        File.Move(folder + "/DATA/files/banner.tpl.png", _bannersPath + di.Name + ".png");

                        BannerImageList.Images.Add(Image.FromFile(_bannersPath + di.Name + ".png"));

                        lst.Text = di.Name;
                        lst.ImageIndex = BannerImageList.Images.Count - 1;
                        BannersListView.Items.Add(lst);

                        break;

                    default:
                        BannersListView.Items.Add("Do not have banner config for game:" + di.Name);
                        break;
                }
            }

            LoadBannersButton.Enabled = false;
        }

        private void Extract(string arcPath)
        {
            string appPath = Path.Combine(_toolsPath, @"wiimm\bin\wszst.exe");

            System.Diagnostics.Process.Start(appPath, "extract " + arcPath);

        }

        private void DecodeImage(string btiPath)
        {
            string appPath = Path.Combine(_toolsPath, @"wiimm\bin\wimgt.exe");

            System.Diagnostics.Process.Start(appPath, "decode " + btiPath);
        }
    }
}
