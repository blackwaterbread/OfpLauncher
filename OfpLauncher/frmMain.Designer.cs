﻿namespace OfpLauncher
{
    partial class frmMain
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTerminateWhenStart = new System.Windows.Forms.CheckBox();
            this.LstMods = new System.Windows.Forms.ListView();
            this.columnModName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddons = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.chkNotConnect = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtParameters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNosplash = new System.Windows.Forms.CheckBox();
            this.chkNomap = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGameStartFullScreen = new System.Windows.Forms.Button();
            this.btnSetup32 = new System.Windows.Forms.Button();
            this.btnSetup64 = new System.Windows.Forms.Button();
            this.lblGithub = new System.Windows.Forms.Label();
            this.btnAspectRatio = new System.Windows.Forms.Button();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.btnGameStartWindowed = new System.Windows.Forms.Button();
            this.btnServerConfig = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chkTerminateWhenStart);
            this.groupBox1.Controls.Add(this.LstMods);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(520, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "모드 선택";
            // 
            // chkTerminateWhenStart
            // 
            this.chkTerminateWhenStart.AutoSize = true;
            this.chkTerminateWhenStart.Checked = true;
            this.chkTerminateWhenStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTerminateWhenStart.Location = new System.Drawing.Point(368, 343);
            this.chkTerminateWhenStart.Name = "chkTerminateWhenStart";
            this.chkTerminateWhenStart.Size = new System.Drawing.Size(146, 19);
            this.chkTerminateWhenStart.TabIndex = 6;
            this.chkTerminateWhenStart.Text = "게임 실행시 런쳐 끄기";
            this.chkTerminateWhenStart.UseVisualStyleBackColor = true;
            // 
            // LstMods
            // 
            this.LstMods.BackColor = System.Drawing.Color.White;
            this.LstMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnModName,
            this.columnAddons});
            this.LstMods.ForeColor = System.Drawing.Color.Black;
            this.LstMods.FullRowSelect = true;
            this.LstMods.GridLines = true;
            this.LstMods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstMods.HideSelection = false;
            this.LstMods.Location = new System.Drawing.Point(6, 15);
            this.LstMods.MultiSelect = false;
            this.LstMods.Name = "LstMods";
            this.LstMods.Size = new System.Drawing.Size(508, 222);
            this.LstMods.TabIndex = 2;
            this.LstMods.UseCompatibleStateImageBehavior = false;
            this.LstMods.View = System.Windows.Forms.View.Details;
            this.LstMods.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LstMods_ItemSelectionChanged);
            // 
            // columnModName
            // 
            this.columnModName.Text = "모드";
            this.columnModName.Width = 120;
            // 
            // columnAddons
            // 
            this.columnAddons.Text = "구성 애드온";
            this.columnAddons.Width = 420;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.chkNotConnect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtHostname);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(264, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 94);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "서버 연결";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "포트";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(193, 57);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(51, 23);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "2302";
            // 
            // chkNotConnect
            // 
            this.chkNotConnect.AutoSize = true;
            this.chkNotConnect.Checked = true;
            this.chkNotConnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotConnect.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkNotConnect.Location = new System.Drawing.Point(9, 18);
            this.chkNotConnect.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.chkNotConnect.Name = "chkNotConnect";
            this.chkNotConnect.Size = new System.Drawing.Size(50, 19);
            this.chkNotConnect.TabIndex = 6;
            this.chkNotConnect.Text = "안함";
            this.chkNotConnect.UseVisualStyleBackColor = true;
            this.chkNotConnect.CheckedChanged += new System.EventHandler(this.chkHost_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "호스트";
            // 
            // txtHostname
            // 
            this.txtHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHostname.Enabled = false;
            this.txtHostname.Location = new System.Drawing.Point(10, 57);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(174, 23);
            this.txtHostname.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtParameters);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.chkNosplash);
            this.groupBox4.Controls.Add(this.chkNomap);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(6, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 94);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "파라미터 설정";
            // 
            // txtParameters
            // 
            this.txtParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParameters.Location = new System.Drawing.Point(9, 57);
            this.txtParameters.Name = "txtParameters";
            this.txtParameters.Size = new System.Drawing.Size(235, 23);
            this.txtParameters.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "추가 파라미터";
            // 
            // chkNosplash
            // 
            this.chkNosplash.AutoSize = true;
            this.chkNosplash.Checked = true;
            this.chkNosplash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNosplash.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkNosplash.Location = new System.Drawing.Point(87, 19);
            this.chkNosplash.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.chkNosplash.Name = "chkNosplash";
            this.chkNosplash.Size = new System.Drawing.Size(77, 19);
            this.chkNosplash.TabIndex = 2;
            this.chkNosplash.Text = "nosplash";
            this.chkNosplash.UseVisualStyleBackColor = true;
            // 
            // chkNomap
            // 
            this.chkNomap.AutoSize = true;
            this.chkNomap.Checked = true;
            this.chkNomap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNomap.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkNomap.Location = new System.Drawing.Point(9, 19);
            this.chkNomap.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.chkNomap.Name = "chkNomap";
            this.chkNomap.Size = new System.Drawing.Size(66, 19);
            this.chkNomap.TabIndex = 2;
            this.chkNomap.Text = "nomap";
            this.chkNomap.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Revision 7";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGameStartFullScreen
            // 
            this.btnGameStartFullScreen.Location = new System.Drawing.Point(407, 387);
            this.btnGameStartFullScreen.Name = "btnGameStartFullScreen";
            this.btnGameStartFullScreen.Size = new System.Drawing.Size(125, 40);
            this.btnGameStartFullScreen.TabIndex = 1;
            this.btnGameStartFullScreen.Text = "게임 실행\r\n(전체화면)";
            this.btnGameStartFullScreen.UseVisualStyleBackColor = true;
            this.btnGameStartFullScreen.Click += new System.EventHandler(this.btnGameStartFullScreen_Click);
            // 
            // btnSetup32
            // 
            this.btnSetup32.Location = new System.Drawing.Point(12, 387);
            this.btnSetup32.Name = "btnSetup32";
            this.btnSetup32.Size = new System.Drawing.Size(125, 40);
            this.btnSetup32.TabIndex = 2;
            this.btnSetup32.Text = "설치 (32비트)";
            this.btnSetup32.UseVisualStyleBackColor = true;
            this.btnSetup32.Click += new System.EventHandler(this.btnSetup32_Click);
            // 
            // btnSetup64
            // 
            this.btnSetup64.Location = new System.Drawing.Point(12, 433);
            this.btnSetup64.Name = "btnSetup64";
            this.btnSetup64.Size = new System.Drawing.Size(125, 40);
            this.btnSetup64.TabIndex = 3;
            this.btnSetup64.Text = "설치 (64비트)";
            this.btnSetup64.UseVisualStyleBackColor = true;
            this.btnSetup64.Click += new System.EventHandler(this.btnSetup64_Click);
            // 
            // lblGithub
            // 
            this.lblGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGithub.Font = new System.Drawing.Font("맑은 고딕", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGithub.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGithub.Location = new System.Drawing.Point(12, 476);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(520, 16);
            this.lblGithub.TabIndex = 5;
            this.lblGithub.Text = "OfpLauncher - @dayrain";
            this.lblGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGithub.Click += new System.EventHandler(this.lblGithub_Click);
            // 
            // btnAspectRatio
            // 
            this.btnAspectRatio.Location = new System.Drawing.Point(143, 387);
            this.btnAspectRatio.Name = "btnAspectRatio";
            this.btnAspectRatio.Size = new System.Drawing.Size(125, 40);
            this.btnAspectRatio.TabIndex = 7;
            this.btnAspectRatio.Text = "화면비 변경";
            this.btnAspectRatio.UseVisualStyleBackColor = true;
            this.btnAspectRatio.Click += new System.EventHandler(this.btnAspectRatio_Click);
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(407, 433);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(125, 40);
            this.btnServerStart.TabIndex = 8;
            this.btnServerStart.Text = "서버 실행";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // btnGameStartWindowed
            // 
            this.btnGameStartWindowed.Location = new System.Drawing.Point(276, 387);
            this.btnGameStartWindowed.Name = "btnGameStartWindowed";
            this.btnGameStartWindowed.Size = new System.Drawing.Size(125, 40);
            this.btnGameStartWindowed.TabIndex = 10;
            this.btnGameStartWindowed.Text = "게임 실행\r\n(창모드)";
            this.btnGameStartWindowed.UseVisualStyleBackColor = true;
            this.btnGameStartWindowed.Click += new System.EventHandler(this.btnGameStartWindowed_Click);
            // 
            // btnServerConfig
            // 
            this.btnServerConfig.Enabled = false;
            this.btnServerConfig.Location = new System.Drawing.Point(276, 433);
            this.btnServerConfig.Name = "btnServerConfig";
            this.btnServerConfig.Size = new System.Drawing.Size(125, 40);
            this.btnServerConfig.TabIndex = 7;
            this.btnServerConfig.Text = "서버 설정";
            this.btnServerConfig.UseVisualStyleBackColor = true;
            this.btnServerConfig.Click += new System.EventHandler(this.btnServerConfig_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(143, 433);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "업데이트 확인";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 501);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGameStartWindowed);
            this.Controls.Add(this.btnAspectRatio);
            this.Controls.Add(this.btnServerStart);
            this.Controls.Add(this.btnServerConfig);
            this.Controls.Add(this.lblGithub);
            this.Controls.Add(this.btnSetup64);
            this.Controls.Add(this.btnSetup32);
            this.Controls.Add(this.btnGameStartFullScreen);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGameStartFullScreen;
        private System.Windows.Forms.ListView LstMods;
        private System.Windows.Forms.ColumnHeader columnModName;
        private System.Windows.Forms.ColumnHeader columnAddons;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.CheckBox chkNotConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkNosplash;
        private System.Windows.Forms.CheckBox chkNomap;
        private System.Windows.Forms.TextBox txtParameters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetup32;
        private System.Windows.Forms.Button btnSetup64;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGithub;
        private System.Windows.Forms.CheckBox chkTerminateWhenStart;
        private System.Windows.Forms.Button btnAspectRatio;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.Button btnGameStartWindowed;
        private System.Windows.Forms.Button btnServerConfig;
        private System.Windows.Forms.Button btnUpdate;
    }
}

