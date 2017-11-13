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

namespace Autodesk_File_Removal_Tool
{
    public partial class frm_frontPage : Form
    {
        public frm_frontPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            var appdata_roaming = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Autodesk");
            var appdata_local = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Autodesk");

            if (Directory.Exists("C:/Program Files (x86)/Autodesk"))
            {
                lbl_status.Text = "Deleting Directory: C:/Program Files (x86)/Autodesk";

                try
                {
                    File.SetAttributes("C:/Program Files (x86)/Autodesk", FileAttributes.Normal);
                    Directory.Delete("C:/Program Files (x86)/Autodesk", true);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please verify that all Autodesk software is either uninstalled or not running.");
                }
            }
            else
            {

            }

            if (Directory.Exists("C:/ProgramData/Autodesk"))
            {
                lbl_status.Text = "Deleting Directory: C:/ProgramData/Autodesk";

                try
                {
                    File.SetAttributes("C:/ProgramData/Autodesk", FileAttributes.Normal);
                    Directory.Delete("C:/ProgramData/Autodesk", true);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please verify that all Autodesk software is either uninstalled or not running.");
                }
            }
            else
            {

            }

            if (Directory.Exists("C:/Program Files/Autodesk"))
            {

                lbl_status.Text = "Deleting Directory: C:/Program Files/Autodesk";

                try
                {
                    File.SetAttributes("C:/Program Files/Autodesk", FileAttributes.Normal);
                    Directory.Delete("C:/Program Files/Autodesk", true);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please verify that all Autodesk software is either uninstalled or not running.");
                }
            }
            else
            {

            }

            if (Directory.Exists(appdata_roaming))
            {

                lbl_status.Text = "Deleting Directory: %appdata%/Autodesk";

                try
                {
                    File.SetAttributes(appdata_roaming, FileAttributes.Normal);
                    Directory.Delete(appdata_roaming, true);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please verify that all Autodesk software is either uninstalled or not running.");
                }
            }
            else
            {

            }

            if (Directory.Exists(appdata_local))
            {

                lbl_status.Text = "Deleting Directory: %localappdata%/Autodesk";

                try
                {
                    File.SetAttributes(appdata_local, FileAttributes.Normal);
                    Directory.Delete(appdata_local, true);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please verify that all Autodesk software is either uninstalled or not running.");
                }
            }
            else
            {

            }

            if (chk_flexnet.Checked)
            {

                lbl_status.Text = "Deleting Directory: C:/ProgramData/FLEXnet";

                if (Directory.Exists("C:/ProgramData/FLEXnet"))
                {
                    try
                    {
                        File.SetAttributes("C:/ProgramData/FLEXnet", FileAttributes.Normal);
                        Directory.Delete("C:/ProgramData/FLEXnet", true);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Please verify that all Autodesk software is either uninstalled or not running.");
                    }
                }
            }

            if (chk_installer.Checked)
            {
                lbl_status.Text = "Deleting Directory: C:/Autodesk";

                if (Directory.Exists("C:/Autodesk"))
                {
                    try
                    {
                        File.SetAttributes("C:/Autodesk", FileAttributes.Normal);
                        Directory.Delete("C:/Autodesk", true);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Please verify that all Autodesk software is either uninstalled or not running.");
                    }
                }
            }

            lbl_status.Text = "All Directories Cleared!";

        }
    }
}
