using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace WAVPlayer
{
    public partial class frmWAVPlayer : Form
    {
        // 依照簡報使用 System.Media.SoundPlayer 控制 WAV 播放。
        // 這裡使用欄位保存播放器物件，讓「停止播放」可以停止同一個播放器。
        private SoundPlayer player = new SoundPlayer();

        public frmWAVPlayer()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // 過濾條件設定為 WAV 檔案。
            ofdWAVFile.Filter = "WAV Files (*.wav)|*.wav";
            ofdWAVFile.DefaultExt = "wav";
            ofdWAVFile.FileName = string.Empty;

            // 打開檔案對話方塊。
            if (ofdWAVFile.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofdWAVFile.FileName;
                lblStatus.Text = "已選擇音效檔案";
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!PreparePlayer())
            {
                return;
            }

            try
            {
                player.Load();       // 將音效資料載入記憶體。
                player.Play();       // 播放已載入記憶體的音效一次。
                lblStatus.Text = "播放一次中...";
            }
            catch (Exception ex)
            {
                MessageBox.Show("播放失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "播放失敗";
            }
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (!PreparePlayer())
            {
                return;
            }

            try
            {
                player.Load();            // 將音效資料載入記憶體。
                player.PlayLooping();     // 重複播放直到 Stop() 被執行。
                lblStatus.Text = "重複播放中...";
            }
            catch (Exception ex)
            {
                MessageBox.Show("重複播放失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "重複播放失敗";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();                // 停止正在播放的音效。
            lblStatus.Text = "已停止播放";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmWAVPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "確定要關閉應用程式嗎？",
                "關閉確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;          // 取消關閉。
                return;
            }

            player.Stop();
            player.Dispose();
        }

        private bool PreparePlayer()
        {
            string fileName = txtPath.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("請先按「瀏覽」選擇 WAV 音效檔。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPath.Focus();
                return false;
            }

            if (!File.Exists(fileName))
            {
                MessageBox.Show("找不到指定的 WAV 檔案，請重新選擇。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPath.Focus();
                return false;
            }

            if (!Path.GetExtension(fileName).Equals(".wav", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("此程式只支援 WAV 音效檔。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPath.Focus();
                return false;
            }

            player.Stop();
            player.SoundLocation = fileName;
            return true;
        }
    }
}
