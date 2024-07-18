namespace antibb
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            activar_autotuning = new Button();
            desactivar_autotuning = new Button();
            activar_rss = new Button();
            desactivar_rss = new Button();
            lblStatus = new Label();
            label1 = new Label();
            speedtest_net = new Button();
            fast_com = new Button();
            lblNetworkStatus = new Label();
            lblAutoTuningStatus = new Label();
            lblRssStatus = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // activar_autotuning
            // 
            activar_autotuning.BackColor = Color.GreenYellow;
            activar_autotuning.Cursor = Cursors.Hand;
            activar_autotuning.FlatAppearance.BorderColor = Color.GreenYellow;
            activar_autotuning.Font = new Font("Verdana", 11.25F);
            activar_autotuning.Location = new Point(108, 212);
            activar_autotuning.Name = "activar_autotuning";
            activar_autotuning.Size = new Size(273, 51);
            activar_autotuning.TabIndex = 1;
            activar_autotuning.Text = "Normal Auto-Tuning";
            activar_autotuning.UseVisualStyleBackColor = false;
            activar_autotuning.Click += activar_autotuning_Click;
            // 
            // desactivar_autotuning
            // 
            desactivar_autotuning.BackColor = Color.GreenYellow;
            desactivar_autotuning.Cursor = Cursors.Hand;
            desactivar_autotuning.FlatAppearance.BorderColor = Color.GreenYellow;
            desactivar_autotuning.Font = new Font("Verdana", 11.25F);
            desactivar_autotuning.Location = new Point(385, 212);
            desactivar_autotuning.Name = "desactivar_autotuning";
            desactivar_autotuning.Size = new Size(273, 51);
            desactivar_autotuning.TabIndex = 2;
            desactivar_autotuning.Text = "Disable Auto-Tuning";
            desactivar_autotuning.UseVisualStyleBackColor = false;
            desactivar_autotuning.Click += desactivar_autotuning_Click;
            // 
            // activar_rss
            // 
            activar_rss.BackColor = Color.GreenYellow;
            activar_rss.Cursor = Cursors.Hand;
            activar_rss.FlatAppearance.BorderColor = Color.GreenYellow;
            activar_rss.Font = new Font("Verdana", 11.25F);
            activar_rss.Location = new Point(385, 272);
            activar_rss.Name = "activar_rss";
            activar_rss.Size = new Size(273, 51);
            activar_rss.TabIndex = 3;
            activar_rss.Text = "Enable RSS";
            activar_rss.UseVisualStyleBackColor = false;
            activar_rss.Click += activar_rss_Click;
            // 
            // desactivar_rss
            // 
            desactivar_rss.BackColor = Color.GreenYellow;
            desactivar_rss.Cursor = Cursors.Hand;
            desactivar_rss.FlatAppearance.BorderColor = Color.GreenYellow;
            desactivar_rss.Font = new Font("Verdana", 11.25F);
            desactivar_rss.Location = new Point(108, 272);
            desactivar_rss.Name = "desactivar_rss";
            desactivar_rss.Size = new Size(273, 51);
            desactivar_rss.TabIndex = 4;
            desactivar_rss.Text = "Disable RSS";
            desactivar_rss.UseVisualStyleBackColor = false;
            desactivar_rss.Click += desactivar_rss_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(334, 110);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(101, 40);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            lblStatus.Click += lblStatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(229, 23);
            label1.Name = "label1";
            label1.Size = new Size(311, 47);
            label1.TabIndex = 6;
            label1.Text = "Anti-BufferBloat";
            label1.Click += label1_Click;
            // 
            // speedtest_net
            // 
            speedtest_net.BackColor = Color.GreenYellow;
            speedtest_net.Cursor = Cursors.Hand;
            speedtest_net.FlatAppearance.BorderColor = Color.GreenYellow;
            speedtest_net.Font = new Font("Verdana", 11.25F);
            speedtest_net.Location = new Point(108, 333);
            speedtest_net.Name = "speedtest_net";
            speedtest_net.Size = new Size(273, 51);
            speedtest_net.TabIndex = 7;
            speedtest_net.Text = "Speedtest.net";
            speedtest_net.UseVisualStyleBackColor = false;
            speedtest_net.Click += speedtest_net_Click;
            // 
            // fast_com
            // 
            fast_com.BackColor = Color.GreenYellow;
            fast_com.Cursor = Cursors.Hand;
            fast_com.FlatAppearance.BorderColor = Color.GreenYellow;
            fast_com.Font = new Font("Verdana", 11.25F);
            fast_com.Location = new Point(385, 333);
            fast_com.Name = "fast_com";
            fast_com.Size = new Size(273, 51);
            fast_com.TabIndex = 8;
            fast_com.Text = "BufferBloat Test";
            fast_com.UseVisualStyleBackColor = false;
            fast_com.Click += fast_com_Click;
            // 
            // lblNetworkStatus
            // 
            lblNetworkStatus.AutoSize = true;
            lblNetworkStatus.BackColor = Color.Transparent;
            lblNetworkStatus.FlatStyle = FlatStyle.Flat;
            lblNetworkStatus.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetworkStatus.ForeColor = Color.GreenYellow;
            lblNetworkStatus.Location = new Point(74, 70);
            lblNetworkStatus.Name = "lblNetworkStatus";
            lblNetworkStatus.Size = new Size(174, 30);
            lblNetworkStatus.TabIndex = 9;
            lblNetworkStatus.Text = "Network Status";
            // 
            // lblAutoTuningStatus
            // 
            lblAutoTuningStatus.AutoSize = true;
            lblAutoTuningStatus.BackColor = Color.Transparent;
            lblAutoTuningStatus.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblAutoTuningStatus.ForeColor = Color.White;
            lblAutoTuningStatus.Location = new Point(192, 153);
            lblAutoTuningStatus.Name = "lblAutoTuningStatus";
            lblAutoTuningStatus.Size = new Size(165, 21);
            lblAutoTuningStatus.TabIndex = 10;
            lblAutoTuningStatus.Text = "Auto-Tuning Status";
            // 
            // lblRssStatus
            // 
            lblRssStatus.AutoSize = true;
            lblRssStatus.BackColor = Color.Transparent;
            lblRssStatus.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblRssStatus.ForeColor = Color.White;
            lblRssStatus.Location = new Point(192, 174);
            lblRssStatus.Name = "lblRssStatus";
            lblRssStatus.Size = new Size(93, 21);
            lblRssStatus.TabIndex = 11;
            lblRssStatus.Text = "RSS Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.GreenYellow;
            label2.Location = new Point(242, 415);
            label2.Name = "label2";
            label2.Size = new Size(284, 25);
            label2.TabIndex = 12;
            label2.Text = "Activition ID: Katatonia#9757768";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(480, 254);
            label3.Name = "label3";
            label3.Size = new Size(83, 13);
            label3.TabIndex = 13;
            label3.Text = "Recommended";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(480, 314);
            label4.Name = "label4";
            label4.Size = new Size(83, 13);
            label4.TabIndex = 14;
            label4.Text = "Recommended";
            // 
            // Form1
            // 
            AccessibleName = "Anti-BufferBloat";
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(784, 461);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblRssStatus);
            Controls.Add(lblAutoTuningStatus);
            Controls.Add(lblNetworkStatus);
            Controls.Add(fast_com);
            Controls.Add(speedtest_net);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(desactivar_rss);
            Controls.Add(activar_rss);
            Controls.Add(desactivar_autotuning);
            Controls.Add(activar_autotuning);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anti-BufferBloat 3.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button activar_autotuning;
        private System.Windows.Forms.Button desactivar_autotuning;
        private System.Windows.Forms.Button activar_rss;
        private System.Windows.Forms.Button desactivar_rss;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button speedtest_net;
        private System.Windows.Forms.Button fast_com;
        private System.Windows.Forms.Label lblNetworkStatus;
        private System.Windows.Forms.Label lblAutoTuningStatus;
        private System.Windows.Forms.Label lblRssStatus;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
