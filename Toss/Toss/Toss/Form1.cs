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
using Toss.Util;

namespace Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Debug
            string localPath = @"D:\Local\";
            
            InitializeComponent();
            
            //Local Directory List
            viewLocalListView(localPath);
        }

        private FtpInfo ReadFtpConfig()
        {
            FtpInfo ftpInfo = new FtpInfo();
            if(txt_Host.Text != string.Empty)
                ftpInfo.host = txt_Host.Text;
            if(txt_Id.Text != string.Empty)
                ftpInfo.id = txt_Id.Text;
            if (txt_Password.Text != string.Empty)
                ftpInfo.password = txt_Password.Text;
            if (txt_Port.Text != string.Empty)
                ftpInfo.port = Int32.Parse(txt_Port.Text);
            ftpInfo.passiveMode = true;
            ftpInfo.remotePath = "/";
            ftpInfo.lFiles = new List<string>();

            return ftpInfo;
        }
        //닫기 버튼
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //접속 버튼
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            //Debug
            txt_Host.Text = @"localhost";
            txt_Id.Text = @"test";
            txt_Password.Text = @"test";
            
            //FTP Config
            FtpInfo info = ReadFtpConfig();
            ftp ftpClient = new ftp(string.Format(@"ftp://{0}/{1}",info.host, info.remotePath), info.id, info.password);

            //Remote Directory List
            viewRemoteListView(info, ftpClient, "/");

        }

        //업로드 버튼 ( '<' )
        private void btn_upload_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            string localFullPath = string.Empty;
            string remoteFullPath = string.Empty;
            FtpInfo info = ReadFtpConfig();
            ftp ftpClient = new ftp(string.Format(@"ftp://{0}/{1}", info.host, info.remotePath), info.id, info.password);
            
            fileName =listBox_Local.SelectedItem.ToString();
            info.lFiles.Add(fileName);
            localFullPath = string.Format(@"{0}{1}",txt_localpath.Text, fileName);
            remoteFullPath = string.Format(@"{0}/{1}",txt_remothPath.Text,fileName);
            ftpClient.upload(remoteFullPath, localFullPath, true, true);

            //Remote Directory List
            viewRemoteListView(info, ftpClient, txt_remothPath.Text);
        }

        //다운로드 버튼 ( '>' )
        private void btn_Download_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            string localFullPath = string.Empty;
            FtpInfo info = ReadFtpConfig();
            ftp ftpClient = new ftp(string.Format(@"ftp://{0}/{1}", info.host, info.remotePath), info.id, info.password);

            fileName = listBox_Remote.SelectedItem.ToString();
            info.lFiles.Add(fileName);
            localFullPath = string.Format(@"{0}{1}", txt_localpath.Text, fileName);

            ftpClient.download(fileName, localFullPath);

            //Local Directory List
            viewLocalListView(txt_localpath.Text);
        }

        

        private void viewLocalListView(string localPath)
        {
            if (System.IO.Directory.Exists(localPath))
            {
                List<string> arr = new List<string>();
                ListViewItem lvi = new ListViewItem("..");
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(localPath);
                if (listBox_Local.Items.Count > 0)
                    listBox_Local.Items.Clear();
                if (listView_Local.Items.Count > 0)
                    listView_Local.Items.Clear();

                listBox_Local.Items.Add("..");
                listView_Local.Items.Add(lvi);
                txt_localpath.Text = localPath;


                foreach (var dir in di.GetDirectories())
                    arr.Add(dir.ToString());
                    //listBox_Local.Items.Add(dir);

                foreach (var files in di.GetFiles())
                    arr.Add(files.ToString());
                    //listBox_Local.Items.Add(files);

            }
            else
            {
                string msg = string.Format("LocalPath가 존재 하지 않습니다. ({0})", localPath);
                MessageBox.Show(msg);
            }
        }
        
        private void viewRemoteListView(FtpInfo info, ftp ftpClient, string remotePath)
        {
            string[] dirInfo = ftpClient.directoryListDetailed(remotePath);
            string dir_name = string.Empty;
            string dir_option = string.Empty;
            string Temp = string.Empty;
            txt_remothPath.Text = remotePath;

            if (listBox_Remote.Items.Count > 0)
                listBox_Remote.Items.Clear();
            listBox_Remote.Items.Add("..");
            
            foreach (string dir in dirInfo)
            {
                if(dir.Length > 1)
                { 
                    //dir -> "drwxr-xr-x 1 ftp ftp              0 Sep 07 17:04 folder1"
                    dir_name = dir.Substring(dir.LastIndexOf(':') + 4);
                    dir_option = dir.Substring(0,dir.IndexOf(' '));

                    if (dir_name.IndexOf('/') > 0)
                    {
                        Temp = dir_name.Substring(dir.LastIndexOf('/') + 1);
                        listBox_Remote.Items.Add(Temp);
                    }
                    else
                        listBox_Remote.Items.Add(dir_name);
                }
            }
        }

        //Local 더블클릭 이벤트 (경로 이동)
        private void listBox_Local_DoubleClick(object sender, EventArgs e)
        {
            string localPath = string.Empty;
            string[] temp = txt_localpath.Text.Split('\\');

            if (listBox_Local.SelectedIndex == 0 && temp.Count() > 2)
            {
                for (int i = 0; i < temp.Count() - 2; i++)
                {
                    if (temp[i] != string.Empty)
                        localPath += string.Format(@"{0}\", temp[i]);
                }
                viewLocalListView(localPath);
            }
            else if (listBox_Local.SelectedIndex > 0)
            {
                localPath = string.Format(@"{0}{1}\", txt_localpath.Text, listBox_Local.SelectedItem);
                viewLocalListView(localPath);
            }
        }

        private void listBox_Local_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                listBox_Local_DoubleClick(sender, e);
            
        }

        //Remote 더블클릭 이벤트 (경로 이동)
        private void listBox_Remote_DoubleClick(object sender, EventArgs e)
        {
            string localPath = string.Empty;
            string[] temp = txt_remothPath.Text.Split('/');
            
            FtpInfo info = ReadFtpConfig();
            ftp ftpClient = new ftp(string.Format(@"ftp://{0}/{1}", info.host, info.remotePath), info.id, info.password);
            
            if (listBox_Remote.SelectedIndex == 0 && temp.Count() >1&& temp[1] != string.Empty)
            {
                for (int i = 0; i < temp.Count()-1; i++)
                {
                    if (temp[i] != string.Empty)
                    {
                        if (info.remotePath == "/")
                            info.remotePath += string.Format(@"{0}", temp[i]);
                        else
                            info.remotePath += string.Format(@"/{0}", temp[i]);
                    }
                        
                }
                
                viewRemoteListView(info, ftpClient, info.remotePath);
            }
            else if (listBox_Remote.SelectedIndex > 0)
            {
                if(txt_remothPath.Text == "/")
                    info.remotePath = string.Format(@"{0}{1}", txt_remothPath.Text, listBox_Remote.SelectedItem);
                else
                    info.remotePath = string.Format(@"{0}/{1}", txt_remothPath.Text, listBox_Remote.SelectedItem);
                viewRemoteListView(info, ftpClient, info.remotePath);
            }
        }

        private void listView_Local_DoubleClick(object sender, EventArgs e)
        {
            string localPath = string.Empty;
            string[] temp = txt_localpath.Text.Split('\\');
            
            if (listBox_Local.SelectedIndex == 0 && temp.Count() > 2)
            {
                for (int i = 0; i < temp.Count() - 2; i++)
                {
                    if (temp[i] != string.Empty)
                        localPath += string.Format(@"{0}\", temp[i]);
                }
                viewLocalListView(localPath);
            }
            else if (listBox_Local.SelectedIndex > 0)
            {
                localPath = string.Format(@"{0}{1}\", txt_localpath.Text, listBox_Local.SelectedItem);
                viewLocalListView(localPath);
            }
        }

        private void listView_Local_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                listBox_Local_DoubleClick(sender, e);
        }
    }
}
