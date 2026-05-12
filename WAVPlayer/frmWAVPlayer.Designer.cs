namespace WAVPlayer
{
    partial class frmWAVPlayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法，請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPath = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.ofdWAVFile = new System.Windows.Forms.OpenFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpPath.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPath
            // 
            this.grpPath.Controls.Add(this.btnBrowse);
            this.grpPath.Controls.Add(this.txtPath);
            this.grpPath.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.grpPath.Location = new System.Drawing.Point(24, 96);
            this.grpPath.Name = "grpPath";
            this.grpPath.Size = new System.Drawing.Size(664, 80);
            this.grpPath.TabIndex = 0;
            this.grpPath.TabStop = false;
            this.grpPath.Text = "音效位置";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.btnBrowse.Location = new System.Drawing.Point(544, 32);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(96, 32);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "瀏覽";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtPath.Location = new System.Drawing.Point(16, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(512, 27);
            this.txtPath.TabIndex = 0;
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.btnEnd);
            this.grpButton.Controls.Add(this.btnStop);
            this.grpButton.Controls.Add(this.btnLoop);
            this.grpButton.Controls.Add(this.btnPlay);
            this.grpButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.grpButton.Location = new System.Drawing.Point(24, 192);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(664, 88);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "播放按鈕";
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.btnEnd.Location = new System.Drawing.Point(512, 32);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(128, 36);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "結束程式";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.btnStop.Location = new System.Drawing.Point(352, 32);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 36);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止播放";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.btnLoop.Location = new System.Drawing.Point(176, 32);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(128, 36);
            this.btnLoop.TabIndex = 1;
            this.btnLoop.Text = "重複播放";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.btnPlay.Location = new System.Drawing.Point(16, 32);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(128, 36);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "播放一次";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // ofdWAVFile
            // 
            this.ofdWAVFile.DefaultExt = "wav";
            this.ofdWAVFile.FileName = "";
            this.ofdWAVFile.Filter = "WAV Files (*.wav)|*.wav";
            this.ofdWAVFile.Title = "選擇 WAV 音效檔";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(664, 48);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "WAV 音效檔播放器";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(24, 72);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(664, 2);
            this.lblLine.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(24, 292);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(664, 28);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "請先選擇 WAV 音效檔";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmWAVPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 331);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPath);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmWAVPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WAV 音效檔播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWAVPlayer_FormClosing);
            this.grpPath.ResumeLayout(false);
            this.grpPath.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.OpenFileDialog ofdWAVFile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblStatus;
    }
}
