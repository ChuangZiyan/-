namespace 同步器.窗體
{
    partial class 滑鼠坐標
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(滑鼠坐標));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.barKeyboardShortcutTextBox1 = new ActiproSoftware.UI.WinForms.Controls.Bars.BarKeyboardShortcutTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "句柄";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "綁定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // barKeyboardShortcutTextBox1
            // 
            this.barKeyboardShortcutTextBox1.Location = new System.Drawing.Point(47, 62);
            this.barKeyboardShortcutTextBox1.Name = "barKeyboardShortcutTextBox1";
            this.barKeyboardShortcutTextBox1.Size = new System.Drawing.Size(148, 21);
            this.barKeyboardShortcutTextBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "坐標";
            // 
            // 滑鼠坐標
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barKeyboardShortcutTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "滑鼠坐標";
            this.Text = "滑鼠坐標";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private ActiproSoftware.UI.WinForms.Controls.Bars.BarKeyboardShortcutTextBox barKeyboardShortcutTextBox1;
        private System.Windows.Forms.Label label2;
    }
}