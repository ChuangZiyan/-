namespace 同步器
{
    partial class 控制窗體
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(控制窗體));
            this.工具欄 = new System.Windows.Forms.ToolStrip();
            this.獲取句柄 = new System.Windows.Forms.ToolStripButton();
            this.開啟同步 = new System.Windows.Forms.ToolStripButton();
            this.關閉同步 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.統一大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.統一前台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.腳本管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部綁定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.輸入文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量啟動ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.右鍵 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.發送中文 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.獲取 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.句柄集合 = new System.Windows.Forms.ListView();
            this.T1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.T2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.T3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.T4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.T5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.工具欄.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.右鍵.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 工具欄
            // 
            this.工具欄.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.工具欄.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.獲取句柄,
            this.開啟同步,
            this.關閉同步,
            this.toolStripDropDownButton1});
            this.工具欄.Location = new System.Drawing.Point(0, 0);
            this.工具欄.Name = "工具欄";
            this.工具欄.Size = new System.Drawing.Size(584, 25);
            this.工具欄.TabIndex = 0;
            this.工具欄.Text = "toolStrip1";
            // 
            // 獲取句柄
            // 
            this.獲取句柄.Image = global::同步器.Properties.Resources.settings_20px;
            this.獲取句柄.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.獲取句柄.Name = "獲取句柄";
            this.獲取句柄.Size = new System.Drawing.Size(76, 22);
            this.獲取句柄.Text = "獲取句柄";
            this.獲取句柄.Click += new System.EventHandler(this.獲取句柄_Click);
            // 
            // 開啟同步
            // 
            this.開啟同步.Image = global::同步器.Properties.Resources.settings_20px;
            this.開啟同步.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟同步.Name = "開啟同步";
            this.開啟同步.Size = new System.Drawing.Size(76, 22);
            this.開啟同步.Text = "開啟同步";
            this.開啟同步.Click += new System.EventHandler(this.開啟同步_Click);
            // 
            // 關閉同步
            // 
            this.關閉同步.Image = global::同步器.Properties.Resources.settings_20px;
            this.關閉同步.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.關閉同步.Name = "關閉同步";
            this.關閉同步.Size = new System.Drawing.Size(76, 22);
            this.關閉同步.Text = "關閉同步";
            this.關閉同步.Click += new System.EventHandler(this.關閉同步_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.統一大小ToolStripMenuItem,
            this.統一前台ToolStripMenuItem,
            this.腳本管理ToolStripMenuItem,
            this.全部綁定ToolStripMenuItem,
            this.輸入文本ToolStripMenuItem,
            this.批量啟動ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::同步器.Properties.Resources.settings_20px;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(85, 22);
            this.toolStripDropDownButton1.Text = "其他設定";
            // 
            // 統一大小ToolStripMenuItem
            // 
            this.統一大小ToolStripMenuItem.Name = "統一大小ToolStripMenuItem";
            this.統一大小ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.統一大小ToolStripMenuItem.Text = "統一大小";
            this.統一大小ToolStripMenuItem.Click += new System.EventHandler(this.統一大小ToolStripMenuItem_Click);
            // 
            // 統一前台ToolStripMenuItem
            // 
            this.統一前台ToolStripMenuItem.Name = "統一前台ToolStripMenuItem";
            this.統一前台ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.統一前台ToolStripMenuItem.Text = "統一前台";
            this.統一前台ToolStripMenuItem.Click += new System.EventHandler(this.統一前台ToolStripMenuItem_Click);
            // 
            // 腳本管理ToolStripMenuItem
            // 
            this.腳本管理ToolStripMenuItem.Name = "腳本管理ToolStripMenuItem";
            this.腳本管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.腳本管理ToolStripMenuItem.Text = "腳本管理";
            this.腳本管理ToolStripMenuItem.Click += new System.EventHandler(this.腳本管理ToolStripMenuItem_Click);
            // 
            // 全部綁定ToolStripMenuItem
            // 
            this.全部綁定ToolStripMenuItem.Name = "全部綁定ToolStripMenuItem";
            this.全部綁定ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部綁定ToolStripMenuItem.Text = "全部綁定";
            this.全部綁定ToolStripMenuItem.Click += new System.EventHandler(this.全部綁定ToolStripMenuItem_Click);
            // 
            // 輸入文本ToolStripMenuItem
            // 
            this.輸入文本ToolStripMenuItem.Name = "輸入文本ToolStripMenuItem";
            this.輸入文本ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.輸入文本ToolStripMenuItem.Text = "輸入文本";
            this.輸入文本ToolStripMenuItem.Click += new System.EventHandler(this.輸入文本ToolStripMenuItem_Click);
            // 
            // 批量啟動ToolStripMenuItem
            // 
            this.批量啟動ToolStripMenuItem.Name = "批量啟動ToolStripMenuItem";
            this.批量啟動ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.批量啟動ToolStripMenuItem.Text = "批量啟動";
            this.批量啟動ToolStripMenuItem.Click += new System.EventHandler(this.批量啟動ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.句柄集合);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(584, 483);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 1;
            // 
            // 右鍵
            // 
            this.右鍵.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刪除ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.右鍵.Name = "contextMenuStrip1";
            this.右鍵.Size = new System.Drawing.Size(101, 48);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.刪除ToolStripMenuItem.Text = "刪除";
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.發送中文);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.獲取);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 49);
            this.panel1.TabIndex = 3;
            // 
            // 發送中文
            // 
            this.發送中文.Location = new System.Drawing.Point(12, 13);
            this.發送中文.Name = "發送中文";
            this.發送中文.Size = new System.Drawing.Size(155, 21);
            this.發送中文.TabIndex = 12;
            this.發送中文.Text = "發送中文";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(234, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "排列";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.統一大小ToolStripMenuItem_Click);
            // 
            // 獲取
            // 
            this.獲取.BackColor = System.Drawing.Color.LimeGreen;
            this.獲取.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.獲取.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.獲取.ForeColor = System.Drawing.Color.White;
            this.獲取.Location = new System.Drawing.Point(177, 11);
            this.獲取.Name = "獲取";
            this.獲取.Size = new System.Drawing.Size(40, 26);
            this.獲取.TabIndex = 9;
            this.獲取.Text = "獲取";
            this.獲取.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.Chartreuse;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(584, 149);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // 句柄集合
            // 
            this.句柄集合.CheckBoxes = true;
            this.句柄集合.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.T1,
            this.T2,
            this.T3,
            this.T4,
            this.T5});
            this.句柄集合.Dock = System.Windows.Forms.DockStyle.Fill;
            this.句柄集合.GridLines = true;
            this.句柄集合.HideSelection = false;
            this.句柄集合.Location = new System.Drawing.Point(0, 49);
            this.句柄集合.Name = "句柄集合";
            this.句柄集合.Size = new System.Drawing.Size(584, 281);
            this.句柄集合.SmallImageList = this.imageList1;
            this.句柄集合.TabIndex = 4;
            this.句柄集合.UseCompatibleStateImageBehavior = false;
            this.句柄集合.View = System.Windows.Forms.View.Details;
            // 
            // T1
            // 
            this.T1.Text = "句柄";
            this.T1.Width = 104;
            // 
            // T2
            // 
            this.T2.Text = "標題";
            this.T2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T2.Width = 138;
            // 
            // T3
            // 
            this.T3.Text = "進程";
            this.T3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T3.Width = 87;
            // 
            // T4
            // 
            this.T4.Text = "寬高";
            this.T4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T4.Width = 111;
            // 
            // T5
            // 
            this.T5.Text = "狀態";
            this.T5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T5.Width = 131;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 22);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // 控制窗體
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 508);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.工具欄);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "控制窗體";
            this.Text = "同步器";
            this.Load += new System.EventHandler(this.控制窗體_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.控制窗體_KeyDown);
            this.工具欄.ResumeLayout(false);
            this.工具欄.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.右鍵.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip 工具欄;
        private System.Windows.Forms.ToolStripButton 開啟同步;
        private System.Windows.Forms.ToolStripButton 獲取句柄;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 統一大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 統一前台ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem 腳本管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部綁定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 關閉同步;
        private System.Windows.Forms.ContextMenuStrip 右鍵;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 輸入文本ToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量啟動ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox 發送中文;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button 獲取;
        private System.Windows.Forms.ColumnHeader T1;
        private System.Windows.Forms.ColumnHeader T2;
        private System.Windows.Forms.ColumnHeader T3;
        private System.Windows.Forms.ColumnHeader T4;
        private System.Windows.Forms.ColumnHeader T5;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ListView 句柄集合;
    }
}

