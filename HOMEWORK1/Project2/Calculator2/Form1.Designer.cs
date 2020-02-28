namespace Calculator
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
            this.type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.outcome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.type.Location = new System.Drawing.Point(198, 187);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 23);
            this.type.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(39, 187);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(103, 25);
            this.input1.TabIndex = 2;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(370, 185);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 25);
            this.input2.TabIndex = 3;
            // 
            // outcome
            // 
            this.outcome.Location = new System.Drawing.Point(645, 182);
            this.outcome.Name = "outcome";
            this.outcome.Size = new System.Drawing.Size(143, 25);
            this.outcome.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outcome);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.type);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox outcome;
    }
}

