namespace Toss
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Host = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Host = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grb_local = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txt_localpath = new System.Windows.Forms.TextBox();
            this.listView_Local = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listBox_Local = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.grb_remote = new System.Windows.Forms.GroupBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.txt_remothPath = new System.Windows.Forms.TextBox();
            this.listView_Remote = new System.Windows.Forms.ListView();
            this.listBox_Remote = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grb_local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grb_remote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Connect);
            this.panel1.Controls.Add(this.lbl_Port);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Controls.Add(this.lbl_Id);
            this.panel1.Controls.Add(this.lbl_Host);
            this.panel1.Controls.Add(this.txt_Port);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.txt_Host);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 43);
            this.panel1.TabIndex = 0;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(570, 10);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 8;
            this.btn_Connect.Text = "접속";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(412, 17);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(27, 12);
            this.lbl_Port.TabIndex = 7;
            this.lbl_Port.Text = "Port";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(271, 17);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(29, 12);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "P/W";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(143, 17);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(16, 12);
            this.lbl_Id.TabIndex = 5;
            this.lbl_Id.Text = "ID";
            // 
            // lbl_Host
            // 
            this.lbl_Host.AutoSize = true;
            this.lbl_Host.Location = new System.Drawing.Point(4, 17);
            this.lbl_Host.Name = "lbl_Host";
            this.lbl_Host.Size = new System.Drawing.Size(30, 12);
            this.lbl_Host.TabIndex = 4;
            this.lbl_Host.Text = "Host";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(447, 12);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(100, 21);
            this.txt_Port.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(306, 12);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(100, 21);
            this.txt_Password.TabIndex = 2;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(165, 12);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 21);
            this.txt_Id.TabIndex = 1;
            // 
            // txt_Host
            // 
            this.txt_Host.Location = new System.Drawing.Point(37, 12);
            this.txt_Host.Name = "txt_Host";
            this.txt_Host.Size = new System.Drawing.Size(100, 21);
            this.txt_Host.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 50);
            this.panel2.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Location = new System.Drawing.Point(570, 15);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "닫기";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grb_local);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(657, 250);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 2;
            // 
            // grb_local
            // 
            this.grb_local.Controls.Add(this.splitContainer3);
            this.grb_local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_local.Location = new System.Drawing.Point(0, 0);
            this.grb_local.Name = "grb_local";
            this.grb_local.Size = new System.Drawing.Size(304, 250);
            this.grb_local.TabIndex = 0;
            this.grb_local.TabStop = false;
            this.grb_local.Text = "Local";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 17);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txt_localpath);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.listView_Local);
            this.splitContainer3.Panel2.Controls.Add(this.listBox_Local);
            this.splitContainer3.Size = new System.Drawing.Size(298, 230);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 1;
            // 
            // txt_localpath
            // 
            this.txt_localpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_localpath.Location = new System.Drawing.Point(0, 0);
            this.txt_localpath.Name = "txt_localpath";
            this.txt_localpath.Size = new System.Drawing.Size(298, 21);
            this.txt_localpath.TabIndex = 0;
            // 
            // listView_Local
            // 
            this.listView_Local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Local.Location = new System.Drawing.Point(0, 0);
            this.listView_Local.Name = "listView_Local";
            this.listView_Local.Size = new System.Drawing.Size(298, 201);
            this.listView_Local.SmallImageList = this.imageList1;
            this.listView_Local.TabIndex = 1;
            this.listView_Local.UseCompatibleStateImageBehavior = false;
            this.listView_Local.DoubleClick += new System.EventHandler(this.listView_Local_DoubleClick);
            this.listView_Local.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView_Local_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listBox_Local
            // 
            this.listBox_Local.FormattingEnabled = true;
            this.listBox_Local.ItemHeight = 12;
            this.listBox_Local.Location = new System.Drawing.Point(162, 36);
            this.listBox_Local.Name = "listBox_Local";
            this.listBox_Local.Size = new System.Drawing.Size(136, 160);
            this.listBox_Local.TabIndex = 0;
            this.listBox_Local.DoubleClick += new System.EventHandler(this.listBox_Local_DoubleClick);
            this.listBox_Local.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox_Local_KeyPress);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btn_Download);
            this.splitContainer2.Panel1.Controls.Add(this.btn_upload);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grb_remote);
            this.splitContainer2.Size = new System.Drawing.Size(349, 250);
            this.splitContainer2.SplitterDistance = 41;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(7, 170);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(27, 22);
            this.btn_Download.TabIndex = 1;
            this.btn_Download.Text = "<";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(7, 60);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(27, 22);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = ">";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // grb_remote
            // 
            this.grb_remote.Controls.Add(this.splitContainer4);
            this.grb_remote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_remote.Location = new System.Drawing.Point(0, 0);
            this.grb_remote.Name = "grb_remote";
            this.grb_remote.Size = new System.Drawing.Size(304, 250);
            this.grb_remote.TabIndex = 0;
            this.grb_remote.TabStop = false;
            this.grb_remote.Text = "Remote";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 17);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.txt_remothPath);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.listView_Remote);
            this.splitContainer4.Panel2.Controls.Add(this.listBox_Remote);
            this.splitContainer4.Size = new System.Drawing.Size(298, 230);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 1;
            // 
            // txt_remothPath
            // 
            this.txt_remothPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_remothPath.Location = new System.Drawing.Point(0, 0);
            this.txt_remothPath.Name = "txt_remothPath";
            this.txt_remothPath.Size = new System.Drawing.Size(298, 21);
            this.txt_remothPath.TabIndex = 0;
            // 
            // listView_Remote
            // 
            this.listView_Remote.Location = new System.Drawing.Point(3, 3);
            this.listView_Remote.Name = "listView_Remote";
            this.listView_Remote.Size = new System.Drawing.Size(121, 97);
            this.listView_Remote.SmallImageList = this.imageList1;
            this.listView_Remote.TabIndex = 1;
            this.listView_Remote.UseCompatibleStateImageBehavior = false;
            // 
            // listBox_Remote
            // 
            this.listBox_Remote.FormattingEnabled = true;
            this.listBox_Remote.ItemHeight = 12;
            this.listBox_Remote.Location = new System.Drawing.Point(160, 84);
            this.listBox_Remote.Name = "listBox_Remote";
            this.listBox_Remote.Size = new System.Drawing.Size(138, 112);
            this.listBox_Remote.TabIndex = 0;
            this.listBox_Remote.DoubleClick += new System.EventHandler(this.listBox_Remote_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 343);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "파일 전송 프로그램";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grb_local.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grb_remote.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Host;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Host;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.GroupBox grb_remote;
        private System.Windows.Forms.ListBox listBox_Remote;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.GroupBox grb_local;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox txt_localpath;
        private System.Windows.Forms.ListBox listBox_Local;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox txt_remothPath;
        private System.Windows.Forms.ListView listView_Local;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView_Remote;

    }
}

