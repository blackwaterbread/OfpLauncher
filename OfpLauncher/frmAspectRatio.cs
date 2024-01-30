using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using OfpLauncher.Lib;

namespace OfpLauncher
{
    public partial class frmAspectRatio : Form
    {
        public frmAspectRatio()
        {
            InitializeComponent();
        }

        private void AspectRatioPatch(string aspect)
        {
            var username = Interaction.InputBox("수정할 컨픽의 사용자명을 입력하세요", "해상도 패치");
            var cfgFile = new FileInfo($"{Lib.Constants.CurrentPath}/Users/{username}/UserInfo.cfg");
            var hppFile = new FileInfo($"{Lib.Constants.CurrentPath}/Aspect_Ratio.hpp");
            if (cfgFile.Exists)
            {
                try
                {
                    CfgManager.ChangeAspectRatio(aspect, cfgFile);
                    HppManager.ChangeAspectRatio(aspect, hppFile);
                    MessageBox.Show("해상도 패치가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"작업 도중에 에러가 발생하였습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("패치할 cfg 파일이 존재하지 않는 것 같습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAspectRatio_Load(object sender, EventArgs e)
        {
            foreach (string aspect in Lib.Constants.Aspects.Keys)
            {
                cmbAspectRatio.Items.Add(aspect);
            }
            cmbAspectRatio.SelectedItem = "16:9";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var value = Lib.Constants.GetAspectValues(cmbAspectRatio.Text);
            AspectRatioPatch(cmbAspectRatio.Text);
            this.Close();
        }
    }
}
