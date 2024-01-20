using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfpLauncher.Lib;

namespace OfpLauncher
{
    public partial class frmMain : Form
    {
        public static string CurrentPath = Application.StartupPath;
        private static string ConfigPath = CurrentPath + "/configs.json";

        private ListViewItem lastItemChecked;
        private string SelectedMod = "";
        private string WindowedX = "1280";
        private string WindowedY = "720";

        public frmMain()
        {
            InitializeComponent();
            try
            {
                var configs = JObject.Parse(File.ReadAllText(ConfigPath));
                var mods = (JObject)configs["mods"];
                foreach (var mod in mods)
                {
                    LstMods.Items.Add(mod.Key).SubItems.Add(mod.Value.ToString());
                }
                lastItemChecked = LstMods.Items[0];
                lastItemChecked.Selected = true;
                lastItemChecked.Checked = true;
                SelectedMod = lastItemChecked.SubItems[1].Text;
                txtParameters.Text = configs["parameters"].ToString();
                var windowed = (JObject)configs["windowed"];
                WindowedX = windowed["width"].ToString();
                WindowedY = windowed["height"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private string getParameters()
        {
            var parameters = new string[]
            {
                chkNomap.Checked == true ? "-nomap" : "",
                chkNosplash.Checked == true ? "-nosplash" : "",
                string.IsNullOrEmpty(SelectedMod) ? "" : $"-mod={SelectedMod}",
                txtParameters.Text,
                chkNotConnect.Checked == true ? "" : $"-connect={txtHostname.Text} -port={txtPort.Text}"
            };
            return string.Join(" ", parameters.Except(new string[] { "" }));
        }

        private void saveParameters()
        {
            try
            {
                var configs = JObject.Parse(File.ReadAllText(ConfigPath));
                configs["parameters"] = txtParameters.Text;
                File.WriteAllText(ConfigPath, configs.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"파라미터 저장 도중에 에러가 발생하였습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGameStartFullScreen_Click(object sender, EventArgs e)
        {
            var parameters = getParameters();
            saveParameters();

            try
            {
                Process.Start($"{CurrentPath}/ArmAResistance.exe", $"{parameters}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"실행 파일이 없거나 올바른 경로에 설치하지 않은 것 같습니다: {ex.Message}", "실행 오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (chkTerminateWhenStart.Checked)
                Application.Exit();
        }

        private void btnGameStartWindowed_Click(object sender, EventArgs e)
        {
            var parameters = getParameters();
            saveParameters();

            try
            {
                Process.Start($"{CurrentPath}/lockmouse2.exe", $"-minimize -center -quit");
                Process.Start($"{CurrentPath}/ArmAResistance.exe", $"{parameters} -window -x={WindowedX} -y={WindowedY}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"실행 파일이 없거나 올바른 경로에 설치하지 않은 것 같습니다: {ex.Message}", "실행 오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (chkTerminateWhenStart.Checked)
                Application.Exit();
        }

        private void LstMods_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
                SelectedMod = e.Item.SubItems[1].Text;
            else
                SelectedMod = "";
        }

        private void chkHost_CheckedChanged(object sender, EventArgs e)
        {
            txtHostname.Enabled = !chkNotConnect.Checked;
            txtPort.Enabled = !chkNotConnect.Checked;
        }

        private void lblGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/blackwaterbread/OFPLauncher");
        }

        private void btnSetup32_Click(object sender, EventArgs e)
        {
            Process.Start($"{CurrentPath}/setup-x86.reg");
        }

        private void btnSetup64_Click(object sender, EventArgs e)
        {
            Process.Start($"{CurrentPath}/setup-x64.reg");
        }

        private void AspectRatioPatch(Dictionary<string, string> values)
        {
            var username = Interaction.InputBox("수정할 컨픽의 사용자명을 입력하세요", "해상도 패치");
            var file = new FileInfo($"{CurrentPath}/Users/{username}/UserInfo.cfg");
            if (file.Exists)
            {
                try
                {
                    var cfg = CfgManager.Read(file);
                    foreach (var v in values)
                    {
                        cfg.Configs[v.Key] = v.Value;
                    }
                    CfgManager.Write(cfg, file);
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

        private void btnWide_Click(object sender, EventArgs e)
        {
            var WideValues = new Dictionary<string, string>() {
                { "fovTop", "0.750000;" },
                { "fovLeft", "1.333333;" },
                { "uiTopLeftX", "0.125000;" },
                { "uiTopLeftY", "0.000000;" },
                { "uiBottomRightX", "0.875000;" },
                { "uiBottomRightY", "1.000000;" },
            };
            AspectRatioPatch(WideValues);
        }

        private void btnWideRollback_Click(object sender, EventArgs e)
        {
            var DefaultValues = new Dictionary<string, string>() {
                { "fovTop", "0.750000;" },
                { "fovLeft", "1.000000;" },
                { "uiTopLeftX", "0.000000;" },
                { "uiTopLeftY", "0.000000;" },
                { "uiBottomRightX", "1.000000;" },
                { "uiBottomRightY", "1.000000;" },
            };
            AspectRatioPatch(DefaultValues);
        }

        private void btnServerConfig_Click(object sender, EventArgs e)
        {
            var server = new frmServer();
            server.ShowDialog();
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            var mods = $"-mod={SelectedMod}";
            try
            {
                Process.Start($"{CurrentPath}/ArmAResistance_Server.exe", $"-nomap {mods} -port=2302 -config=server.cfg -netlog");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"서버 파일이 없거나 올바른 경로에 설치하지 않은 것 같습니다: {ex.Message}", "실행 오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}