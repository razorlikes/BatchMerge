using System.Diagnostics;

namespace BatchMerge
{
    public partial class MainForm : Form
    {
        string[] files1, files2;
        Process mergeProcess;
        bool running = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenFolderDest_Click(object sender, EventArgs e)
        {
            fbdDest.ShowDialog();
            var path = fbdDest.SelectedPath;
            tbxPathDest.Text = path;
            var files = Directory.GetFiles(path, ".mkv", SearchOption.AllDirectories);
            lstFilesDest.Items.Clear();
            lstFilesDest.Items.AddRange(files.Select(f => new ListViewItem(Path.GetFileName(f))).ToArray());

            var psi = new ProcessStartInfo
            {
                FileName = "mkvmerge.exe",
                Arguments = $"-J \"{files[0]}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (var process = Process.Start(psi))
            {
                if (process != null)
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    tbxInfoDest.Text = output;
                }
            }

            files1 = files;
        }

        private void btnOpenFolderSrc_Click(object sender, EventArgs e)
        {
            fbdSrc.ShowDialog();
            var path = fbdSrc.SelectedPath;
            tbxPathSrc.Text = path;
            var files = Directory.GetFiles(path, "*S**E**.mkv", SearchOption.AllDirectories);
            lstFilesSrc.Items.Clear();
            lstFilesSrc.Items.AddRange(files.Select(f => new ListViewItem(Path.GetFileName(f))).ToArray());

            var psi = new ProcessStartInfo
            {
                FileName = "mkvmerge.exe",
                Arguments = $"-J \"{files[0]}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (var process = Process.Start(psi))
            {
                if (process != null)
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    tbxInfoSrc.Text = output;
                }
            }

            files2 = files;
        }

        private async void btnStartMerge_Click(object sender, EventArgs e)
        {
            running = true;
            btnStartMerge.Enabled = false;
            btnCancelMerge.Enabled = true;
            pbrTotalProgress.Maximum = files1.Length;

            for (int i = 0; i < files1.Length; i++)
            {
                if (running == false)
                    break;

                var psi = new ProcessStartInfo
                {
                    FileName = "mkvmerge.exe",
                    Arguments =
                        $"-o \"{files1[i].Remove(files1[i].LastIndexOf("."))}-merged.mkv\" " +
                        $"\"{files1[i]}\" " +
                        $"--no-video --no-subtitles --no-buttons --no-track-tags --no-chapters --no-attachments " +
                        $"--audio-tracks {numTrackID.Value} " +
                        $"--default-track {numTrackID.Value}:{(cbxTrackDefault.Checked ? "yes" : "no")} " +
                        $"--forced-track {numTrackID.Value}:{(cbxTrackForced.Checked ? "yes" : "no")} " +
                        $"\"{files2[i]}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                mergeProcess = new Process { StartInfo = psi };

                mergeProcess.OutputDataReceived += (s, ev) =>
                {
                    if (!String.IsNullOrWhiteSpace(ev.Data) && ev.Data.StartsWith("Progress:", StringComparison.OrdinalIgnoreCase))
                    {
                        var percentText = ev.Data.Substring("Progress:".Length).Trim().TrimEnd('%');

                        if (int.TryParse(percentText, out int percent))
                            Invoke(() => { pbrCurrentFile.Value = Math.Min(percent, 100); });
                    }
                };

                mergeProcess.Start();
                mergeProcess.BeginOutputReadLine();

                await mergeProcess.WaitForExitAsync();

                pbrTotalProgress.Value = i + 1;
            }

            running = false;
            btnStartMerge.Enabled = true;
            btnCancelMerge.Enabled = false;
        }

        private void btnCancelMerge_Click(object sender, EventArgs e)
        {
            running = false;
            mergeProcess?.Kill();

            pbrCurrentFile.Value = 0;
            pbrTotalProgress.Value = 0;
            btnStartMerge.Enabled = true;
            btnCancelMerge.Enabled = false;
        }
    }
}
