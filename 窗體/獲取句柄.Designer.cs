namespace 同步器.窗體
{
    partial class 獲取句柄
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(獲取句柄));
            this.label1 = new System.Windows.Forms.Label();
            this.句柄類型 = new System.Windows.Forms.ComboBox();
            this.獲取 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "類型";
            // 
            // 句柄類型
            // 
            this.句柄類型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.句柄類型.FormattingEnabled = true;
            this.句柄類型.Items.AddRange(new object[] {
            "瀏覽器",
            "模擬器",
            "虛擬機"});
            this.句柄類型.Location = new System.Drawing.Point(47, 41);
            this.句柄類型.Name = "句柄類型";
            this.句柄類型.Size = new System.Drawing.Size(129, 20);
            this.句柄類型.TabIndex = 1;
            // 
            // 獲取
            // 
            this.獲取.BackColor = System.Drawing.Color.LimeGreen;
            this.獲取.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.獲取.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.獲取.ForeColor = System.Drawing.Color.White;
            this.獲取.Location = new System.Drawing.Point(82, 81);
            this.獲取.Name = "獲取";
            this.獲取.Size = new System.Drawing.Size(40, 26);
            this.獲取.TabIndex = 8;
            this.獲取.Text = "獲取";
            this.獲取.UseVisualStyleBackColor = false;
            this.獲取.Click += new System.EventHandler(this.獲取_Click);
            // 
            // 獲取句柄
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 129);
            this.Controls.Add(this.獲取);
            this.Controls.Add(this.句柄類型);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "獲取句柄";
            this.Text = "獲取句柄";
            this.Load += new System.EventHandler(this.獲取句柄_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 句柄類型;
        private System.Windows.Forms.Button 獲取;
    }
}