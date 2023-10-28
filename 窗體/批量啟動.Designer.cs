namespace 同步器.窗體
{
    partial class 批量啟動
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(批量啟動));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.打開 = new System.Windows.Forms.ToolStripButton();
            this.儲存 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.啟動 = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打開,
            this.儲存,
            this.toolStripSeparator1,
            this.啟動});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(459, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 打開
            // 
            this.打開.Image = global::同步器.Properties.Resources.settings_20px;
            this.打開.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打開.Name = "打開";
            this.打開.Size = new System.Drawing.Size(52, 22);
            this.打開.Text = "打開";
            // 
            // 儲存
            // 
            this.儲存.Image = global::同步器.Properties.Resources.settings_20px;
            this.儲存.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存.Name = "儲存";
            this.儲存.Size = new System.Drawing.Size(52, 22);
            this.儲存.Text = "儲存";
            this.儲存.Click += new System.EventHandler(this.儲存_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // 啟動
            // 
            this.啟動.Image = global::同步器.Properties.Resources.settings_20px;
            this.啟動.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.啟動.Name = "啟動";
            this.啟動.Size = new System.Drawing.Size(52, 22);
            this.啟動.Text = "啟動";
            this.啟動.Click += new System.EventHandler(this.啟動_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(459, 431);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "chrome|d:\\1|www.google.com\nchrome|d:\\2|www.google.com\nmsedge|d:\\3|www.google.com\n" +
    "msedge|d:\\4|www.google.com";
            // 
            // 批量啟動
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 456);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "批量啟動";
            this.Text = "批量啟動";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 打開;
        private System.Windows.Forms.ToolStripButton 啟動;
        private System.Windows.Forms.ToolStripButton 儲存;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}