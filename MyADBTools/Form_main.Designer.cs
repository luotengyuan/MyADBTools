namespace MyADBTools
{
    partial class Form_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cb_slt_devices = new System.Windows.Forms.ComboBox();
            this.btn_wifi_debug = new System.Windows.Forms.Button();
            this.btn_restart_adb = new System.Windows.Forms.Button();
            this.btn_open_cmd = new System.Windows.Forms.Button();
            this.tb_cmd_log = new System.Windows.Forms.TextBox();
            this.tb_cmd = new System.Windows.Forms.TextBox();
            this.btn_send_cmd = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp_cmd_log = new System.Windows.Forms.TabPage();
            this.tp_device_info = new System.Windows.Forms.TabPage();
            this.tb_device_info = new System.Windows.Forms.TextBox();
            this.tp_app_manager = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_apm_show = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_permission_groups = new System.Windows.Forms.Button();
            this.btn_install_list = new System.Windows.Forms.Button();
            this.btn_permission_list = new System.Windows.Forms.Button();
            this.btn_system_lib_list = new System.Windows.Forms.Button();
            this.btn_system_feature_list = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_install_path = new System.Windows.Forms.TextBox();
            this.btn_install = new System.Windows.Forms.Button();
            this.btn_uninstall = new System.Windows.Forms.Button();
            this.tb_uninstall_pkg = new System.Windows.Forms.TextBox();
            this.tp_device_control = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_autodloader = new System.Windows.Forms.Button();
            this.btn_fastboot = new System.Windows.Forms.Button();
            this.btn_recovery = new System.Windows.Forms.Button();
            this.btn_reboot = new System.Windows.Forms.Button();
            this.btn_shutdown = new System.Windows.Forms.Button();
            this.tp_key_simulation = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btn_calculator = new System.Windows.Forms.Button();
            this.btn_calendar = new System.Windows.Forms.Button();
            this.btn_music = new System.Windows.Forms.Button();
            this.btn_browser = new System.Windows.Forms.Button();
            this.btn_call = new System.Windows.Forms.Button();
            this.btn_address_list = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btn_hang_up = new System.Windows.Forms.Button();
            this.btn_light_on = new System.Windows.Forms.Button();
            this.btn_sleep = new System.Windows.Forms.Button();
            this.btn_brightness_plus = new System.Windows.Forms.Button();
            this.btn_brightness_down = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btn_next_song = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_prev_song = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn_evoke_assistant = new System.Windows.Forms.Button();
            this.btn_take_photo = new System.Windows.Forms.Button();
            this.btn_volume_off = new System.Windows.Forms.Button();
            this.btn_volume_down = new System.Windows.Forms.Button();
            this.btn_volume_plus = new System.Windows.Forms.Button();
            this.btn_power = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_task = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_disconnect_wifi_debug = new System.Windows.Forms.Button();
            this.btn_set_wifi_debug_port = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tp_cmd_log.SuspendLayout();
            this.tp_device_info.SuspendLayout();
            this.tp_app_manager.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tp_device_control.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tp_key_simulation.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(302, 22);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cb_slt_devices
            // 
            this.cb_slt_devices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_slt_devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_slt_devices.FormattingEnabled = true;
            this.cb_slt_devices.Location = new System.Drawing.Point(18, 24);
            this.cb_slt_devices.Name = "cb_slt_devices";
            this.cb_slt_devices.Size = new System.Drawing.Size(277, 20);
            this.cb_slt_devices.TabIndex = 1;
            this.cb_slt_devices.SelectedIndexChanged += new System.EventHandler(this.cb_slt_devices_SelectedIndexChanged);
            // 
            // btn_wifi_debug
            // 
            this.btn_wifi_debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_wifi_debug.Location = new System.Drawing.Point(734, 24);
            this.btn_wifi_debug.Name = "btn_wifi_debug";
            this.btn_wifi_debug.Size = new System.Drawing.Size(75, 23);
            this.btn_wifi_debug.TabIndex = 2;
            this.btn_wifi_debug.Text = "无线调试";
            this.btn_wifi_debug.UseVisualStyleBackColor = true;
            this.btn_wifi_debug.Click += new System.EventHandler(this.btn_wifi_debug_Click);
            // 
            // btn_restart_adb
            // 
            this.btn_restart_adb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restart_adb.Location = new System.Drawing.Point(815, 24);
            this.btn_restart_adb.Name = "btn_restart_adb";
            this.btn_restart_adb.Size = new System.Drawing.Size(75, 23);
            this.btn_restart_adb.TabIndex = 3;
            this.btn_restart_adb.Text = "重启ADB";
            this.btn_restart_adb.UseVisualStyleBackColor = true;
            this.btn_restart_adb.Click += new System.EventHandler(this.btn_restart_adb_Click);
            // 
            // btn_open_cmd
            // 
            this.btn_open_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open_cmd.Location = new System.Drawing.Point(896, 23);
            this.btn_open_cmd.Name = "btn_open_cmd";
            this.btn_open_cmd.Size = new System.Drawing.Size(75, 23);
            this.btn_open_cmd.TabIndex = 4;
            this.btn_open_cmd.Text = "打开CMD";
            this.btn_open_cmd.UseVisualStyleBackColor = true;
            this.btn_open_cmd.Click += new System.EventHandler(this.btn_open_cmd_Click);
            // 
            // tb_cmd_log
            // 
            this.tb_cmd_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_cmd_log.Location = new System.Drawing.Point(6, 6);
            this.tb_cmd_log.Multiline = true;
            this.tb_cmd_log.Name = "tb_cmd_log";
            this.tb_cmd_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_cmd_log.Size = new System.Drawing.Size(933, 364);
            this.tb_cmd_log.TabIndex = 14;
            // 
            // tb_cmd
            // 
            this.tb_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_cmd.Location = new System.Drawing.Point(6, 376);
            this.tb_cmd.Name = "tb_cmd";
            this.tb_cmd.Size = new System.Drawing.Size(826, 21);
            this.tb_cmd.TabIndex = 15;
            // 
            // btn_send_cmd
            // 
            this.btn_send_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send_cmd.Location = new System.Drawing.Point(838, 376);
            this.btn_send_cmd.Name = "btn_send_cmd";
            this.btn_send_cmd.Size = new System.Drawing.Size(101, 25);
            this.btn_send_cmd.TabIndex = 16;
            this.btn_send_cmd.Text = "发送命令";
            this.btn_send_cmd.UseVisualStyleBackColor = true;
            this.btn_send_cmd.Click += new System.EventHandler(this.btn_send_cmd_Click);
            // 
            // tabControl
            // 
            this.tabControl.AccessibleDescription = "";
            this.tabControl.AccessibleName = "";
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tp_cmd_log);
            this.tabControl.Controls.Add(this.tp_device_info);
            this.tabControl.Controls.Add(this.tp_app_manager);
            this.tabControl.Controls.Add(this.tp_device_control);
            this.tabControl.Controls.Add(this.tp_key_simulation);
            this.tabControl.Location = new System.Drawing.Point(17, 24);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(953, 433);
            this.tabControl.TabIndex = 17;
            this.tabControl.Tag = "";
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tp_cmd_log
            // 
            this.tp_cmd_log.Controls.Add(this.tb_cmd_log);
            this.tp_cmd_log.Controls.Add(this.btn_send_cmd);
            this.tp_cmd_log.Controls.Add(this.tb_cmd);
            this.tp_cmd_log.Location = new System.Drawing.Point(4, 22);
            this.tp_cmd_log.Name = "tp_cmd_log";
            this.tp_cmd_log.Padding = new System.Windows.Forms.Padding(3);
            this.tp_cmd_log.Size = new System.Drawing.Size(945, 407);
            this.tp_cmd_log.TabIndex = 2;
            this.tp_cmd_log.Text = "命令日志";
            this.tp_cmd_log.UseVisualStyleBackColor = true;
            // 
            // tp_device_info
            // 
            this.tp_device_info.Controls.Add(this.tb_device_info);
            this.tp_device_info.Location = new System.Drawing.Point(4, 22);
            this.tp_device_info.Name = "tp_device_info";
            this.tp_device_info.Padding = new System.Windows.Forms.Padding(3);
            this.tp_device_info.Size = new System.Drawing.Size(945, 407);
            this.tp_device_info.TabIndex = 0;
            this.tp_device_info.Text = "设备信息";
            this.tp_device_info.UseVisualStyleBackColor = true;
            // 
            // tb_device_info
            // 
            this.tb_device_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_device_info.Location = new System.Drawing.Point(6, 3);
            this.tb_device_info.Multiline = true;
            this.tb_device_info.Name = "tb_device_info";
            this.tb_device_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_device_info.Size = new System.Drawing.Size(933, 398);
            this.tb_device_info.TabIndex = 0;
            // 
            // tp_app_manager
            // 
            this.tp_app_manager.Controls.Add(this.groupBox5);
            this.tp_app_manager.Controls.Add(this.groupBox4);
            this.tp_app_manager.Controls.Add(this.groupBox3);
            this.tp_app_manager.Location = new System.Drawing.Point(4, 22);
            this.tp_app_manager.Name = "tp_app_manager";
            this.tp_app_manager.Padding = new System.Windows.Forms.Padding(3);
            this.tp_app_manager.Size = new System.Drawing.Size(945, 407);
            this.tp_app_manager.TabIndex = 1;
            this.tp_app_manager.Text = "应用管理";
            this.tp_app_manager.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.tb_apm_show);
            this.groupBox5.Location = new System.Drawing.Point(6, 153);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(931, 248);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "数量展示";
            // 
            // tb_apm_show
            // 
            this.tb_apm_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_apm_show.Location = new System.Drawing.Point(6, 20);
            this.tb_apm_show.Multiline = true;
            this.tb_apm_show.Name = "tb_apm_show";
            this.tb_apm_show.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_apm_show.Size = new System.Drawing.Size(919, 222);
            this.tb_apm_show.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btn_permission_groups);
            this.groupBox4.Controls.Add(this.btn_install_list);
            this.groupBox4.Controls.Add(this.btn_permission_list);
            this.groupBox4.Controls.Add(this.btn_system_lib_list);
            this.groupBox4.Controls.Add(this.btn_system_feature_list);
            this.groupBox4.Controls.Add(this.btn_user);
            this.groupBox4.Location = new System.Drawing.Point(6, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(931, 54);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "应用信息";
            // 
            // btn_permission_groups
            // 
            this.btn_permission_groups.Location = new System.Drawing.Point(249, 20);
            this.btn_permission_groups.Name = "btn_permission_groups";
            this.btn_permission_groups.Size = new System.Drawing.Size(75, 23);
            this.btn_permission_groups.TabIndex = 4;
            this.btn_permission_groups.Text = "权限组";
            this.btn_permission_groups.UseVisualStyleBackColor = true;
            this.btn_permission_groups.Click += new System.EventHandler(this.btn_permission_groups_Click);
            // 
            // btn_install_list
            // 
            this.btn_install_list.Location = new System.Drawing.Point(6, 20);
            this.btn_install_list.Name = "btn_install_list";
            this.btn_install_list.Size = new System.Drawing.Size(75, 23);
            this.btn_install_list.TabIndex = 5;
            this.btn_install_list.Text = "已安装列表";
            this.btn_install_list.UseVisualStyleBackColor = true;
            this.btn_install_list.Click += new System.EventHandler(this.btn_install_list_Click);
            // 
            // btn_permission_list
            // 
            this.btn_permission_list.Location = new System.Drawing.Point(330, 20);
            this.btn_permission_list.Name = "btn_permission_list";
            this.btn_permission_list.Size = new System.Drawing.Size(75, 23);
            this.btn_permission_list.TabIndex = 3;
            this.btn_permission_list.Text = "权限列表";
            this.btn_permission_list.UseVisualStyleBackColor = true;
            this.btn_permission_list.Click += new System.EventHandler(this.btn_permission_list_Click);
            // 
            // btn_system_lib_list
            // 
            this.btn_system_lib_list.Location = new System.Drawing.Point(168, 20);
            this.btn_system_lib_list.Name = "btn_system_lib_list";
            this.btn_system_lib_list.Size = new System.Drawing.Size(75, 23);
            this.btn_system_lib_list.TabIndex = 8;
            this.btn_system_lib_list.Text = "系统库列表";
            this.btn_system_lib_list.UseVisualStyleBackColor = true;
            this.btn_system_lib_list.Click += new System.EventHandler(this.btn_system_lib_list_Click);
            // 
            // btn_system_feature_list
            // 
            this.btn_system_feature_list.Location = new System.Drawing.Point(87, 20);
            this.btn_system_feature_list.Name = "btn_system_feature_list";
            this.btn_system_feature_list.Size = new System.Drawing.Size(75, 23);
            this.btn_system_feature_list.TabIndex = 6;
            this.btn_system_feature_list.Text = "系统功能列表";
            this.btn_system_feature_list.UseVisualStyleBackColor = true;
            this.btn_system_feature_list.Click += new System.EventHandler(this.btn_system_feature_list_Click);
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(411, 20);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(75, 23);
            this.btn_user.TabIndex = 7;
            this.btn_user.Text = "用户列表";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tb_install_path);
            this.groupBox3.Controls.Add(this.btn_install);
            this.groupBox3.Controls.Add(this.btn_uninstall);
            this.groupBox3.Controls.Add(this.tb_uninstall_pkg);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(931, 81);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "安装卸载";
            // 
            // tb_install_path
            // 
            this.tb_install_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_install_path.Location = new System.Drawing.Point(6, 20);
            this.tb_install_path.Name = "tb_install_path";
            this.tb_install_path.Size = new System.Drawing.Size(838, 21);
            this.tb_install_path.TabIndex = 9;
            // 
            // btn_install
            // 
            this.btn_install.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_install.Location = new System.Drawing.Point(850, 18);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(75, 23);
            this.btn_install.TabIndex = 0;
            this.btn_install.Text = "安装应用";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // btn_uninstall
            // 
            this.btn_uninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_uninstall.Location = new System.Drawing.Point(850, 45);
            this.btn_uninstall.Name = "btn_uninstall";
            this.btn_uninstall.Size = new System.Drawing.Size(75, 23);
            this.btn_uninstall.TabIndex = 1;
            this.btn_uninstall.Text = "卸载应用";
            this.btn_uninstall.UseVisualStyleBackColor = true;
            this.btn_uninstall.Click += new System.EventHandler(this.btn_uninstall_Click);
            // 
            // tb_uninstall_pkg
            // 
            this.tb_uninstall_pkg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_uninstall_pkg.Location = new System.Drawing.Point(6, 47);
            this.tb_uninstall_pkg.Name = "tb_uninstall_pkg";
            this.tb_uninstall_pkg.Size = new System.Drawing.Size(838, 21);
            this.tb_uninstall_pkg.TabIndex = 2;
            // 
            // tp_device_control
            // 
            this.tp_device_control.Controls.Add(this.groupBox6);
            this.tp_device_control.Location = new System.Drawing.Point(4, 22);
            this.tp_device_control.Name = "tp_device_control";
            this.tp_device_control.Padding = new System.Windows.Forms.Padding(3);
            this.tp_device_control.Size = new System.Drawing.Size(945, 407);
            this.tp_device_control.TabIndex = 3;
            this.tp_device_control.Text = "设备控制";
            this.tp_device_control.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.btn_autodloader);
            this.groupBox6.Controls.Add(this.btn_fastboot);
            this.groupBox6.Controls.Add(this.btn_recovery);
            this.groupBox6.Controls.Add(this.btn_reboot);
            this.groupBox6.Controls.Add(this.btn_shutdown);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(931, 55);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // btn_autodloader
            // 
            this.btn_autodloader.Location = new System.Drawing.Point(330, 20);
            this.btn_autodloader.Name = "btn_autodloader";
            this.btn_autodloader.Size = new System.Drawing.Size(75, 23);
            this.btn_autodloader.TabIndex = 4;
            this.btn_autodloader.Text = "autodloader";
            this.btn_autodloader.UseVisualStyleBackColor = true;
            this.btn_autodloader.Click += new System.EventHandler(this.btn_autodloader_Click);
            // 
            // btn_fastboot
            // 
            this.btn_fastboot.Location = new System.Drawing.Point(249, 20);
            this.btn_fastboot.Name = "btn_fastboot";
            this.btn_fastboot.Size = new System.Drawing.Size(75, 23);
            this.btn_fastboot.TabIndex = 3;
            this.btn_fastboot.Text = "Fastboot";
            this.btn_fastboot.UseVisualStyleBackColor = true;
            this.btn_fastboot.Click += new System.EventHandler(this.btn_fastboot_Click);
            // 
            // btn_recovery
            // 
            this.btn_recovery.Location = new System.Drawing.Point(168, 20);
            this.btn_recovery.Name = "btn_recovery";
            this.btn_recovery.Size = new System.Drawing.Size(75, 23);
            this.btn_recovery.TabIndex = 2;
            this.btn_recovery.Text = "Recovery";
            this.btn_recovery.UseVisualStyleBackColor = true;
            this.btn_recovery.Click += new System.EventHandler(this.btn_recovery_Click);
            // 
            // btn_reboot
            // 
            this.btn_reboot.Location = new System.Drawing.Point(87, 20);
            this.btn_reboot.Name = "btn_reboot";
            this.btn_reboot.Size = new System.Drawing.Size(75, 23);
            this.btn_reboot.TabIndex = 1;
            this.btn_reboot.Text = "重启";
            this.btn_reboot.UseVisualStyleBackColor = true;
            this.btn_reboot.Click += new System.EventHandler(this.btn_reboot_Click);
            // 
            // btn_shutdown
            // 
            this.btn_shutdown.Location = new System.Drawing.Point(6, 20);
            this.btn_shutdown.Name = "btn_shutdown";
            this.btn_shutdown.Size = new System.Drawing.Size(75, 23);
            this.btn_shutdown.TabIndex = 0;
            this.btn_shutdown.Text = "关机";
            this.btn_shutdown.UseVisualStyleBackColor = true;
            this.btn_shutdown.Click += new System.EventHandler(this.btn_shutdown_Click);
            // 
            // tp_key_simulation
            // 
            this.tp_key_simulation.Controls.Add(this.groupBox11);
            this.tp_key_simulation.Controls.Add(this.groupBox10);
            this.tp_key_simulation.Controls.Add(this.groupBox9);
            this.tp_key_simulation.Controls.Add(this.groupBox8);
            this.tp_key_simulation.Controls.Add(this.groupBox7);
            this.tp_key_simulation.Location = new System.Drawing.Point(4, 22);
            this.tp_key_simulation.Name = "tp_key_simulation";
            this.tp_key_simulation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_key_simulation.Size = new System.Drawing.Size(945, 407);
            this.tp_key_simulation.TabIndex = 4;
            this.tp_key_simulation.Text = "按键模拟";
            this.tp_key_simulation.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.btn_calculator);
            this.groupBox11.Controls.Add(this.btn_calendar);
            this.groupBox11.Controls.Add(this.btn_music);
            this.groupBox11.Controls.Add(this.btn_browser);
            this.groupBox11.Controls.Add(this.btn_call);
            this.groupBox11.Controls.Add(this.btn_address_list);
            this.groupBox11.Controls.Add(this.btn_setting);
            this.groupBox11.Location = new System.Drawing.Point(6, 250);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(931, 55);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "拉起系统应用";
            // 
            // btn_calculator
            // 
            this.btn_calculator.Location = new System.Drawing.Point(492, 20);
            this.btn_calculator.Name = "btn_calculator";
            this.btn_calculator.Size = new System.Drawing.Size(75, 23);
            this.btn_calculator.TabIndex = 7;
            this.btn_calculator.Text = "计算器";
            this.btn_calculator.UseVisualStyleBackColor = true;
            this.btn_calculator.Click += new System.EventHandler(this.btn_calculator_Click);
            // 
            // btn_calendar
            // 
            this.btn_calendar.Location = new System.Drawing.Point(411, 20);
            this.btn_calendar.Name = "btn_calendar";
            this.btn_calendar.Size = new System.Drawing.Size(75, 23);
            this.btn_calendar.TabIndex = 6;
            this.btn_calendar.Text = "日历";
            this.btn_calendar.UseVisualStyleBackColor = true;
            this.btn_calendar.Click += new System.EventHandler(this.btn_calendar_Click);
            // 
            // btn_music
            // 
            this.btn_music.Location = new System.Drawing.Point(330, 20);
            this.btn_music.Name = "btn_music";
            this.btn_music.Size = new System.Drawing.Size(75, 23);
            this.btn_music.TabIndex = 4;
            this.btn_music.Text = "音乐";
            this.btn_music.UseVisualStyleBackColor = true;
            this.btn_music.Click += new System.EventHandler(this.btn_music_Click);
            // 
            // btn_browser
            // 
            this.btn_browser.Location = new System.Drawing.Point(249, 20);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(75, 23);
            this.btn_browser.TabIndex = 3;
            this.btn_browser.Text = "浏览器";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.btn_browser_Click);
            // 
            // btn_call
            // 
            this.btn_call.Location = new System.Drawing.Point(168, 20);
            this.btn_call.Name = "btn_call";
            this.btn_call.Size = new System.Drawing.Size(75, 23);
            this.btn_call.TabIndex = 2;
            this.btn_call.Text = "拨号";
            this.btn_call.UseVisualStyleBackColor = true;
            this.btn_call.Click += new System.EventHandler(this.btn_call_Click);
            // 
            // btn_address_list
            // 
            this.btn_address_list.Location = new System.Drawing.Point(87, 20);
            this.btn_address_list.Name = "btn_address_list";
            this.btn_address_list.Size = new System.Drawing.Size(75, 23);
            this.btn_address_list.TabIndex = 1;
            this.btn_address_list.Text = "通讯录";
            this.btn_address_list.UseVisualStyleBackColor = true;
            this.btn_address_list.Click += new System.EventHandler(this.btn_address_list_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(6, 20);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(75, 23);
            this.btn_setting.TabIndex = 0;
            this.btn_setting.Text = "设置";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.btn_hang_up);
            this.groupBox10.Controls.Add(this.btn_light_on);
            this.groupBox10.Controls.Add(this.btn_sleep);
            this.groupBox10.Controls.Add(this.btn_brightness_plus);
            this.groupBox10.Controls.Add(this.btn_brightness_down);
            this.groupBox10.Location = new System.Drawing.Point(6, 189);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(931, 55);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "其他指令";
            // 
            // btn_hang_up
            // 
            this.btn_hang_up.Location = new System.Drawing.Point(330, 20);
            this.btn_hang_up.Name = "btn_hang_up";
            this.btn_hang_up.Size = new System.Drawing.Size(75, 23);
            this.btn_hang_up.TabIndex = 4;
            this.btn_hang_up.Text = "挂断电话";
            this.btn_hang_up.UseVisualStyleBackColor = true;
            this.btn_hang_up.Click += new System.EventHandler(this.btn_hang_up_Click);
            // 
            // btn_light_on
            // 
            this.btn_light_on.Location = new System.Drawing.Point(249, 20);
            this.btn_light_on.Name = "btn_light_on";
            this.btn_light_on.Size = new System.Drawing.Size(75, 23);
            this.btn_light_on.TabIndex = 3;
            this.btn_light_on.Text = "点亮屏幕";
            this.btn_light_on.UseVisualStyleBackColor = true;
            this.btn_light_on.Click += new System.EventHandler(this.btn_light_on_Click);
            // 
            // btn_sleep
            // 
            this.btn_sleep.Location = new System.Drawing.Point(168, 20);
            this.btn_sleep.Name = "btn_sleep";
            this.btn_sleep.Size = new System.Drawing.Size(75, 23);
            this.btn_sleep.TabIndex = 2;
            this.btn_sleep.Text = "系统休眠";
            this.btn_sleep.UseVisualStyleBackColor = true;
            this.btn_sleep.Click += new System.EventHandler(this.btn_sleep_Click);
            // 
            // btn_brightness_plus
            // 
            this.btn_brightness_plus.Location = new System.Drawing.Point(6, 20);
            this.btn_brightness_plus.Name = "btn_brightness_plus";
            this.btn_brightness_plus.Size = new System.Drawing.Size(75, 23);
            this.btn_brightness_plus.TabIndex = 1;
            this.btn_brightness_plus.Text = "亮度 +";
            this.btn_brightness_plus.UseVisualStyleBackColor = true;
            this.btn_brightness_plus.Click += new System.EventHandler(this.btn_brightness_plus_Click);
            // 
            // btn_brightness_down
            // 
            this.btn_brightness_down.Location = new System.Drawing.Point(87, 20);
            this.btn_brightness_down.Name = "btn_brightness_down";
            this.btn_brightness_down.Size = new System.Drawing.Size(75, 23);
            this.btn_brightness_down.TabIndex = 0;
            this.btn_brightness_down.Text = "亮度 -";
            this.btn_brightness_down.UseVisualStyleBackColor = true;
            this.btn_brightness_down.Click += new System.EventHandler(this.btn_brightness_down_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.btn_next_song);
            this.groupBox9.Controls.Add(this.btn_pause);
            this.groupBox9.Controls.Add(this.btn_continue);
            this.groupBox9.Controls.Add(this.btn_prev_song);
            this.groupBox9.Controls.Add(this.btn_stop);
            this.groupBox9.Controls.Add(this.btn_play);
            this.groupBox9.Location = new System.Drawing.Point(6, 128);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(931, 55);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "媒体控制";
            // 
            // btn_next_song
            // 
            this.btn_next_song.Location = new System.Drawing.Point(411, 20);
            this.btn_next_song.Name = "btn_next_song";
            this.btn_next_song.Size = new System.Drawing.Size(75, 23);
            this.btn_next_song.TabIndex = 5;
            this.btn_next_song.Text = "下一曲";
            this.btn_next_song.UseVisualStyleBackColor = true;
            this.btn_next_song.Click += new System.EventHandler(this.btn_next_song_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(330, 20);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "暂停";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(249, 20);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(75, 23);
            this.btn_continue.TabIndex = 3;
            this.btn_continue.Text = "继续";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_prev_song
            // 
            this.btn_prev_song.Location = new System.Drawing.Point(168, 20);
            this.btn_prev_song.Name = "btn_prev_song";
            this.btn_prev_song.Size = new System.Drawing.Size(75, 23);
            this.btn_prev_song.TabIndex = 2;
            this.btn_prev_song.Text = "上一曲";
            this.btn_prev_song.UseVisualStyleBackColor = true;
            this.btn_prev_song.Click += new System.EventHandler(this.btn_prev_song_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(87, 20);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "停止播放";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(6, 20);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "播放音乐";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.btn_evoke_assistant);
            this.groupBox8.Controls.Add(this.btn_take_photo);
            this.groupBox8.Controls.Add(this.btn_volume_off);
            this.groupBox8.Controls.Add(this.btn_volume_down);
            this.groupBox8.Controls.Add(this.btn_volume_plus);
            this.groupBox8.Controls.Add(this.btn_power);
            this.groupBox8.Location = new System.Drawing.Point(6, 67);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(931, 55);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "实体按键";
            // 
            // btn_evoke_assistant
            // 
            this.btn_evoke_assistant.Location = new System.Drawing.Point(411, 20);
            this.btn_evoke_assistant.Name = "btn_evoke_assistant";
            this.btn_evoke_assistant.Size = new System.Drawing.Size(75, 23);
            this.btn_evoke_assistant.TabIndex = 5;
            this.btn_evoke_assistant.Text = "唤起助理";
            this.btn_evoke_assistant.UseVisualStyleBackColor = true;
            this.btn_evoke_assistant.Click += new System.EventHandler(this.btn_evoke_assistant_Click);
            // 
            // btn_take_photo
            // 
            this.btn_take_photo.Location = new System.Drawing.Point(330, 20);
            this.btn_take_photo.Name = "btn_take_photo";
            this.btn_take_photo.Size = new System.Drawing.Size(75, 23);
            this.btn_take_photo.TabIndex = 4;
            this.btn_take_photo.Text = "拍照";
            this.btn_take_photo.UseVisualStyleBackColor = true;
            this.btn_take_photo.Click += new System.EventHandler(this.btn_take_photo_Click);
            // 
            // btn_volume_off
            // 
            this.btn_volume_off.Location = new System.Drawing.Point(249, 20);
            this.btn_volume_off.Name = "btn_volume_off";
            this.btn_volume_off.Size = new System.Drawing.Size(75, 23);
            this.btn_volume_off.TabIndex = 3;
            this.btn_volume_off.Text = "静音";
            this.btn_volume_off.UseVisualStyleBackColor = true;
            this.btn_volume_off.Click += new System.EventHandler(this.btn_volume_off_Click);
            // 
            // btn_volume_down
            // 
            this.btn_volume_down.Location = new System.Drawing.Point(168, 20);
            this.btn_volume_down.Name = "btn_volume_down";
            this.btn_volume_down.Size = new System.Drawing.Size(75, 23);
            this.btn_volume_down.TabIndex = 2;
            this.btn_volume_down.Text = "音量 -";
            this.btn_volume_down.UseVisualStyleBackColor = true;
            this.btn_volume_down.Click += new System.EventHandler(this.btn_volume_down_Click);
            // 
            // btn_volume_plus
            // 
            this.btn_volume_plus.Location = new System.Drawing.Point(87, 20);
            this.btn_volume_plus.Name = "btn_volume_plus";
            this.btn_volume_plus.Size = new System.Drawing.Size(75, 23);
            this.btn_volume_plus.TabIndex = 1;
            this.btn_volume_plus.Text = "音量 +";
            this.btn_volume_plus.UseVisualStyleBackColor = true;
            this.btn_volume_plus.Click += new System.EventHandler(this.btn_volume_plus_Click);
            // 
            // btn_power
            // 
            this.btn_power.Location = new System.Drawing.Point(6, 20);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(75, 23);
            this.btn_power.TabIndex = 0;
            this.btn_power.Text = "电源键";
            this.btn_power.UseVisualStyleBackColor = true;
            this.btn_power.Click += new System.EventHandler(this.btn_power_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.btn_task);
            this.groupBox7.Controls.Add(this.btn_menu);
            this.groupBox7.Controls.Add(this.btn_home);
            this.groupBox7.Controls.Add(this.btn_back);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(931, 55);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "系统导航";
            // 
            // btn_task
            // 
            this.btn_task.Location = new System.Drawing.Point(249, 20);
            this.btn_task.Name = "btn_task";
            this.btn_task.Size = new System.Drawing.Size(75, 23);
            this.btn_task.TabIndex = 3;
            this.btn_task.Text = "任务键";
            this.btn_task.UseVisualStyleBackColor = true;
            this.btn_task.Click += new System.EventHandler(this.btn_task_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(168, 20);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 23);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.Text = "菜单键";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(87, 20);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "主页键";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(6, 20);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "返回键";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_disconnect_wifi_debug);
            this.groupBox1.Controls.Add(this.btn_set_wifi_debug_port);
            this.groupBox1.Controls.Add(this.cb_slt_devices);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.btn_wifi_debug);
            this.groupBox1.Controls.Add(this.btn_restart_adb);
            this.groupBox1.Controls.Add(this.btn_open_cmd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 64);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备连接";
            // 
            // btn_disconnect_wifi_debug
            // 
            this.btn_disconnect_wifi_debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_disconnect_wifi_debug.Location = new System.Drawing.Point(383, 22);
            this.btn_disconnect_wifi_debug.Name = "btn_disconnect_wifi_debug";
            this.btn_disconnect_wifi_debug.Size = new System.Drawing.Size(124, 23);
            this.btn_disconnect_wifi_debug.TabIndex = 6;
            this.btn_disconnect_wifi_debug.Text = "断开无线调试";
            this.btn_disconnect_wifi_debug.UseVisualStyleBackColor = true;
            this.btn_disconnect_wifi_debug.Click += new System.EventHandler(this.btn_disconnect_wifi_debug_Click);
            // 
            // btn_set_wifi_debug_port
            // 
            this.btn_set_wifi_debug_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_set_wifi_debug_port.Location = new System.Drawing.Point(513, 23);
            this.btn_set_wifi_debug_port.Name = "btn_set_wifi_debug_port";
            this.btn_set_wifi_debug_port.Size = new System.Drawing.Size(153, 23);
            this.btn_set_wifi_debug_port.TabIndex = 5;
            this.btn_set_wifi_debug_port.Text = "设置无线调试端口";
            this.btn_set_wifi_debug_port.UseVisualStyleBackColor = true;
            this.btn_set_wifi_debug_port.Click += new System.EventHandler(this.btn_set_wifi_debug_port_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl);
            this.groupBox2.Location = new System.Drawing.Point(13, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 460);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备控制";
            // 
            // Form_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1001, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(660, 510);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB工具箱";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_FormClosed);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.tabControl.ResumeLayout(false);
            this.tp_cmd_log.ResumeLayout(false);
            this.tp_cmd_log.PerformLayout();
            this.tp_device_info.ResumeLayout(false);
            this.tp_device_info.PerformLayout();
            this.tp_app_manager.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tp_device_control.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tp_key_simulation.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox cb_slt_devices;
        private System.Windows.Forms.Button btn_wifi_debug;
        private System.Windows.Forms.Button btn_restart_adb;
        private System.Windows.Forms.Button btn_open_cmd;
        private System.Windows.Forms.TextBox tb_cmd_log;
        private System.Windows.Forms.TextBox tb_cmd;
        private System.Windows.Forms.Button btn_send_cmd;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tp_device_info;
        private System.Windows.Forms.TabPage tp_app_manager;
        private System.Windows.Forms.TabPage tp_cmd_log;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tp_device_control;
        private System.Windows.Forms.TabPage tp_key_simulation;
        private System.Windows.Forms.TextBox tb_device_info;
        private System.Windows.Forms.Button btn_uninstall;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_install_path;
        private System.Windows.Forms.Button btn_system_lib_list;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_system_feature_list;
        private System.Windows.Forms.Button btn_install_list;
        private System.Windows.Forms.Button btn_permission_groups;
        private System.Windows.Forms.Button btn_permission_list;
        private System.Windows.Forms.TextBox tb_uninstall_pkg;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_apm_show;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_fastboot;
        private System.Windows.Forms.Button btn_recovery;
        private System.Windows.Forms.Button btn_reboot;
        private System.Windows.Forms.Button btn_shutdown;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btn_calculator;
        private System.Windows.Forms.Button btn_calendar;
        private System.Windows.Forms.Button btn_music;
        private System.Windows.Forms.Button btn_browser;
        private System.Windows.Forms.Button btn_call;
        private System.Windows.Forms.Button btn_address_list;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btn_hang_up;
        private System.Windows.Forms.Button btn_light_on;
        private System.Windows.Forms.Button btn_sleep;
        private System.Windows.Forms.Button btn_brightness_plus;
        private System.Windows.Forms.Button btn_brightness_down;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btn_next_song;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_prev_song;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btn_evoke_assistant;
        private System.Windows.Forms.Button btn_take_photo;
        private System.Windows.Forms.Button btn_volume_off;
        private System.Windows.Forms.Button btn_volume_down;
        private System.Windows.Forms.Button btn_volume_plus;
        private System.Windows.Forms.Button btn_power;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_task;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_set_wifi_debug_port;
        private System.Windows.Forms.Button btn_disconnect_wifi_debug;
        private System.Windows.Forms.Button btn_autodloader;
    }
}

