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
        private ListViewItem lastItemChecked;
        private string SelectedMod = "";

        public frmMain()
        {
            InitializeComponent();
            try
            {
                var configs = JObject.Parse(File.ReadAllText(Lib.Constants.ConfigPath));
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
                Lib.Constants.WindowedX = windowed["width"].ToString();
                Lib.Constants.WindowedY = windowed["height"].ToString();
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
                var configs = JObject.Parse(File.ReadAllText(Lib.Constants.ConfigPath));
                configs["parameters"] = txtParameters.Text;
                File.WriteAllText(Lib.Constants.ConfigPath, configs.ToString());
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
                Process.Start($"{Lib.Constants.CurrentPath}/ArmAResistance.exe", $"{parameters}");
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
                Process.Start($"{Lib.Constants.CurrentPath}/lockmouse2.exe", $"-minimize -center -quit");
                Process.Start($"{Lib.Constants.CurrentPath}/ArmAResistance.exe", $"{parameters} -window -x={Lib.Constants.WindowedX} -y={Lib.Constants.WindowedY}");
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
            Process.Start($"{Lib.Constants.CurrentPath}/setup-x86.reg");
        }

        private void btnSetup64_Click(object sender, EventArgs e)
        {
            Process.Start($"{Lib.Constants.CurrentPath}/setup-x64.reg");
        }

        private void btnAspectRatio_Click(object sender, EventArgs e)
        {
            var aspect = new frmAspectRatio();
            aspect.ShowDialog();
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
                Process.Start($"{Lib.Constants.CurrentPath}/ArmAResistance_Server.exe", $"-nomap {mods} -port=2302 -config=server.cfg -netlog");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"서버 파일이 없거나 올바른 경로에 설치하지 않은 것 같습니다: {ex.Message}", "실행 오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}