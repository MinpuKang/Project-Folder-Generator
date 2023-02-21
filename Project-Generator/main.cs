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
using System.Diagnostics;

namespace Project_Generator
{
    public partial class Main_Form : Form
    {
        public string user = Environment.UserName;
        public Main_Form()
        {
            InitializeComponent();

            Folder_textBox.Text = @"C:/Users/" + user + "/Documents/For Projects";
        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            string main_Dir = Folder_textBox.Text.ToString();

            if (Name_textBox.Text.ToString() == "")
            {
                MessageBox.Show("项目名称未设置！", "提示");
                return;
            }

            string sub_dir = "Project-" + Name_textBox.Text.ToString();
            string path = main_Dir + "/" + sub_dir;
            if (Directory.Exists(path))
            {
                MessageBox.Show("此项目已存在，无需创建", "提示");
                return;
            }
            else
            {
                Directory.CreateDirectory(path);

                if (Directory.Exists(path))
                {
                    for (int subfolderIndex = 0; subfolderIndex < textBox_subfolder.Lines.Length; subfolderIndex++)
                    {
                        Directory.CreateDirectory(path + "/" + textBox_subfolder.Lines[subfolderIndex]);
                    }

                    MessageBox.Show("Project " + path + " 创建成功!", "提示");
                    return;
                }
            }

        }

        private void folder_button_Click(object sender, EventArgs e)
        {

            string FolderPath = "";
            FolderBrowserDialog Dialog = new FolderBrowserDialog();
            Dialog.Description = "请选择文件路径";
            //if (!string.IsNullOrWhiteSpace(HistoryPath)) Dialog.SelectedPath = HistoryPath;
            //Dialog.RootFolder = Environment.SpecialFolder.Programs;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = Dialog.SelectedPath;
                if (string.IsNullOrWhiteSpace(FolderPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    //return "";
                }
                else
                {
                    Folder_textBox.Text = FolderPath;
                }
            }
        }

        private void button_reset_subfolder_Click(object sender, EventArgs e)
        {
            textBox_subfolder.Text = "1.Project-Info" + "\r\n" + "2.LLD-HOT-Config" + "\r\n" + "3.TOL-Report" + "\r\n" + "4.Activities" + "\r\n" + "5.Login-Info" + "\r\n" + "6.Logs" + "\r\n" + "7.Trace" + "\r\n" + "8.Software" + "\r\n" + "9.Issues" + "\r\n" + "10.Travel" + "\r\n" + "11.Others";
        }
    }
}
