namespace MyADBTools
{
    partial class Form_wifi_debug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_wifi_debug));
            this.pb_socket_server = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_slt_netcard = new System.Windows.Forms.ComboBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_apk_download = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_socket_server)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_apk_download)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_socket_server
            // 
            this.pb_socket_server.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_socket_server.Location = new System.Drawing.Point(64, 39);
            this.pb_socket_server.Name = "pb_socket_server";
            this.pb_socket_server.Size = new System.Drawing.Size(165, 165);
            this.pb_socket_server.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_socket_server.TabIndex = 1;
            this.pb_socket_server.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "网卡选择：";
            // 
            // cb_slt_netcard
            // 
            this.cb_slt_netcard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_slt_netcard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_slt_netcard.FormattingEnabled = true;
            this.cb_slt_netcard.Location = new System.Drawing.Point(63, 7);
            this.cb_slt_netcard.Name = "cb_slt_netcard";
            this.cb_slt_netcard.Size = new System.Drawing.Size(484, 20);
            this.cb_slt_netcard.TabIndex = 3;
            this.cb_slt_netcard.SelectedValueChanged += new System.EventHandler(this.cb_slt_netcard_SelectedValueChanged);
            // 
            // tb_ip
            // 
            this.tb_ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ip.Location = new System.Drawing.Point(63, 36);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(484, 21);
            this.tb_ip.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP地址：";
            // 
            // tb_port
            // 
            this.tb_port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_port.Enabled = false;
            this.tb_port.Location = new System.Drawing.Point(63, 68);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(484, 21);
            this.tb_port.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "端口号：";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tb_ip);
            this.panel1.Controls.Add(this.cb_slt_netcard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_port);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 97);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pb_apk_download);
            this.panel2.Controls.Add(this.pb_socket_server);
            this.panel2.Location = new System.Drawing.Point(12, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 217);
            this.panel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(322, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "下载【无线ADB调试连接助手】请扫描以下二维码";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(55, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "请使用【无线ADB调试连接助手】扫描以下二维码";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_apk_download
            // 
            this.pb_apk_download.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_apk_download.Location = new System.Drawing.Point(325, 39);
            this.pb_apk_download.Name = "pb_apk_download";
            this.pb_apk_download.Size = new System.Drawing.Size(165, 165);
            this.pb_apk_download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_apk_download.TabIndex = 2;
            this.pb_apk_download.TabStop = false;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(553, 78);
            this.label6.TabIndex = 17;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // Form_wifi_debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_wifi_debug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "无线调试连接";
            this.Load += new System.EventHandler(this.Form_wifi_debug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_socket_server)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_apk_download)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_socket_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_slt_netcard;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_apk_download;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}