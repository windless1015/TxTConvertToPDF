namespace TXTConvertPDF
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_convert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(30, 318);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(86, 23);
            this.button_convert.TabIndex = 0;
            this.button_convert.Text = "转换";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "打开txt文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_txt
            // 
            this.textBox_txt.Location = new System.Drawing.Point(122, 12);
            this.textBox_txt.Multiline = true;
            this.textBox_txt.Name = "textBox_txt";
            this.textBox_txt.Size = new System.Drawing.Size(687, 520);
            this.textBox_txt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 589);
            this.Controls.Add(this.textBox_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_txt;
    }
}

