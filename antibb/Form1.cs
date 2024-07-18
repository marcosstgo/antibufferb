using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antibb
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer pingTimer;
        private readonly HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            pingTimer = new System.Windows.Forms.Timer
            {
                Interval = 5000 // 5 segundos
            };
            pingTimer.Tick += pingTimer_Tick;
            pingTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateNetworkStatus();
            ShowAutoTuningAndRssStatus();
        }

        private void activar_autotuning_Click(object sender, EventArgs e)
        {
            string result = RunCommand("netsh int tcp set global autotuninglevel=normal");
            MessageBox.Show(result, "Auto-Tuning Activado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowAutoTuningAndRssStatus();
        }

        private void desactivar_autotuning_Click(object sender, EventArgs e)
        {
            string result = RunCommand("netsh int tcp set global autotuninglevel=disabled");
            MessageBox.Show(result, "Auto-Tuning Desactivado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowAutoTuningAndRssStatus();
        }

        private void activar_rss_Click(object sender, EventArgs e)
        {
            string result = RunCommand("netsh int tcp set global rss=enabled");
            MessageBox.Show(result, "RSS Activado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowAutoTuningAndRssStatus();
        }

        private void desactivar_rss_Click(object sender, EventArgs e)
        {
            string result = RunCommand("netsh int tcp set global rss=disabled");
            MessageBox.Show(result, "RSS Desactivado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowAutoTuningAndRssStatus();
        }

        private void speedtest_net_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start https://www.speedtest.net") { CreateNoWindow = true });
        }

        private void fast_com_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start https://www.waveform.com/tools/bufferbloat") { CreateNoWindow = true });
        }

        private string RunCommand(string command)
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {command}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private async void UpdateNetworkStatus()
        {
            var ping = GetPing();
            var externalIp = await GetExternalIpAsync();
            var internalIp = GetInternalIp();
            lblNetworkStatus.Text = $"Ping: {ping}ms || IP Ext: {externalIp} || IP Int: {internalIp}";
        }

        private string GetPing()
        {
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send("8.8.8.8");
                    return reply != null && reply.Status == IPStatus.Success ? reply.RoundtripTime.ToString() : "N/A";
                }
            }
            catch
            {
                return "N/A";
            }
        }

        private async Task<string> GetExternalIpAsync()
        {
            try
            {
                var response = await httpClient.GetStringAsync("https://api.ipify.org");
                return response;
            }
            catch
            {
                return "N/A";
            }
        }

        private string GetInternalIp()
        {
            try
            {
                foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                return "N/A";
            }
            catch
            {
                return "N/A";
            }
        }

        private void ShowAutoTuningAndRssStatus()
        {
            string output = RunCommand("netsh int tcp show global");
            string autotuningStatus = "Receive Window Auto-Tuning Level: N/A";
            string rssStatus = "Receive-Side Scaling State: N/A";

            foreach (var line in output.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
            {
                if (line.Contains("Receive Window Auto-Tuning Level"))
                {
                    autotuningStatus = line.Trim();
                }
                else if (line.Contains("Receive-Side Scaling State"))
                {
                    rssStatus = line.Trim();
                }
            }

            lblAutoTuningStatus.Text = autotuningStatus;
            lblRssStatus.Text = rssStatus;
        }

        private void pingTimer_Tick(object sender, EventArgs e)
        {
            UpdateNetworkStatus();
            ShowAutoTuningAndRssStatus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
