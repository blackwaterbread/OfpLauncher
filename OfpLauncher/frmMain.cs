using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace OfpLauncher
{
    public partial class frmMain : Form
    {
        private static string CurrentPath = Application.StartupPath;
        private static string ConfigPath = CurrentPath + "/configs.json";

        private ListViewItem lastItemChecked;
        private string SelectedMod = "";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            var parameters = new string[]
            {
                chkNomap.Checked == true ? "-nomap" : "",
                chkNosplash.Checked == true ? "-nosplash" : "",
                string.IsNullOrEmpty(SelectedMod) ? "" : $"-mod={SelectedMod}",
                txtParameters.Text,
                chkNotConnect.Checked == true ? "" : $"-connect={txtHostname.Text} -port={txtPort.Text}"
            };

            try
            {
                var configs = JObject.Parse(File.ReadAllText(ConfigPath));
                configs["parameters"] = txtParameters.Text;
                File.WriteAllText(ConfigPath, configs.ToString());
            }
            catch (Exception ex)
            {
                // some error an saving configs
            }

            try
            {
                Process.Start($"{CurrentPath}/ArmAResistance.exe", $"{string.Join(" ", parameters.Except(new string[] { "" }))}");
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

        private void btnSettingsLoad_Click(object sender, EventArgs e)
        {

        }
    }
}