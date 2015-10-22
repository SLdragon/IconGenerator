namespace WindowsFormsApplication1
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Checked = true;
            this.checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox.Location = new System.Drawing.Point(108, 76);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(72, 16);
            this.checkbox.TabIndex = 1;
            this.checkbox.Text = "自动生成";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(27, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "手动宽高";
            // 
            // textWidth
            // 
            this.textWidth.Enabled = false;
            this.textWidth.Location = new System.Drawing.Point(98, 107);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(62, 21);
            this.textWidth.TabIndex = 3;
            // 
            // textHeight
            // 
            this.textHeight.Enabled = false;
            this.textHeight.Location = new System.Drawing.Point(178, 107);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(62, 21);
            this.textHeight.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Icon生成工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textHeight;
    }
}

