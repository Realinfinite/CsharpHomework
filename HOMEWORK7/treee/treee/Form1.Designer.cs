namespace treee
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
            this.cB_Color = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_per1 = new System.Windows.Forms.TextBox();
            this.tB_per2 = new System.Windows.Forms.TextBox();
            this.tB_th1 = new System.Windows.Forms.TextBox();
            this.tB_th2 = new System.Windows.Forms.TextBox();
            this.tB_leng = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBarper1 = new System.Windows.Forms.TrackBar();
            this.trackBarper2 = new System.Windows.Forms.TrackBar();
            this.trackBarleng = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarleng)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_Color
            // 
            this.cB_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Color.FormattingEnabled = true;
            this.cB_Color.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Yellow",
            "Green",
            "Black"});
            this.cB_Color.Location = new System.Drawing.Point(498, 71);
            this.cB_Color.Name = "cB_Color";
            this.cB_Color.Size = new System.Drawing.Size(61, 20);
            this.cB_Color.TabIndex = 0;
            this.cB_Color.SelectedIndexChanged += new System.EventHandler(this.cB_Color_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "per1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "per2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "th1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "th2";
            // 
            // tB_per1
            // 
            this.tB_per1.Location = new System.Drawing.Point(498, 113);
            this.tB_per1.Name = "tB_per1";
            this.tB_per1.Size = new System.Drawing.Size(23, 21);
            this.tB_per1.TabIndex = 6;
            this.tB_per1.TextChanged += new System.EventHandler(this.tB_per1_TextChanged);
            // 
            // tB_per2
            // 
            this.tB_per2.Location = new System.Drawing.Point(498, 166);
            this.tB_per2.Name = "tB_per2";
            this.tB_per2.Size = new System.Drawing.Size(23, 21);
            this.tB_per2.TabIndex = 7;
            this.tB_per2.TextChanged += new System.EventHandler(this.tB_per2_TextChanged);
            // 
            // tB_th1
            // 
            this.tB_th1.Location = new System.Drawing.Point(498, 217);
            this.tB_th1.Name = "tB_th1";
            this.tB_th1.Size = new System.Drawing.Size(23, 21);
            this.tB_th1.TabIndex = 8;
            this.tB_th1.TextChanged += new System.EventHandler(this.tB_th1_TextChanged);
            // 
            // tB_th2
            // 
            this.tB_th2.Location = new System.Drawing.Point(498, 269);
            this.tB_th2.Name = "tB_th2";
            this.tB_th2.Size = new System.Drawing.Size(23, 21);
            this.tB_th2.TabIndex = 9;
            this.tB_th2.TextChanged += new System.EventHandler(this.tB_th2_TextChanged);
            // 
            // tB_leng
            // 
            this.tB_leng.Location = new System.Drawing.Point(498, 325);
            this.tB_leng.Name = "tB_leng";
            this.tB_leng.Size = new System.Drawing.Size(23, 21);
            this.tB_leng.TabIndex = 10;
            this.tB_leng.TextChanged += new System.EventHandler(this.tB_leng_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "leng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "n";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(527, 23);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(92, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 21);
            this.textBox1.TabIndex = 15;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(527, 217);
            this.trackBar2.Maximum = 30;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 16;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(527, 269);
            this.trackBar3.Maximum = 30;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 17;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBarper1
            // 
            this.trackBarper1.Location = new System.Drawing.Point(527, 113);
            this.trackBarper1.Name = "trackBarper1";
            this.trackBarper1.Size = new System.Drawing.Size(104, 45);
            this.trackBarper1.TabIndex = 18;
            this.trackBarper1.Scroll += new System.EventHandler(this.trackBarper1_Scroll);
            // 
            // trackBarper2
            // 
            this.trackBarper2.Location = new System.Drawing.Point(527, 166);
            this.trackBarper2.Name = "trackBarper2";
            this.trackBarper2.Size = new System.Drawing.Size(104, 45);
            this.trackBarper2.TabIndex = 19;
            this.trackBarper2.Scroll += new System.EventHandler(this.trackBarper2_Scroll);
            // 
            // trackBarleng
            // 
            this.trackBarleng.Location = new System.Drawing.Point(527, 325);
            this.trackBarleng.Maximum = 100;
            this.trackBarleng.Name = "trackBarleng";
            this.trackBarleng.Size = new System.Drawing.Size(104, 45);
            this.trackBarleng.TabIndex = 20;
            this.trackBarleng.Scroll += new System.EventHandler(this.trackBarleng_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBarleng);
            this.Controls.Add(this.trackBarper2);
            this.Controls.Add(this.trackBarper1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tB_leng);
            this.Controls.Add(this.tB_th2);
            this.Controls.Add(this.tB_th1);
            this.Controls.Add(this.tB_per2);
            this.Controls.Add(this.tB_per1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_Color);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarleng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_per1;
        private System.Windows.Forms.TextBox tB_per2;
        private System.Windows.Forms.TextBox tB_th1;
        private System.Windows.Forms.TextBox tB_th2;
        private System.Windows.Forms.TextBox tB_leng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBarper1;
        private System.Windows.Forms.TrackBar trackBarper2;
        private System.Windows.Forms.TrackBar trackBarleng;
    }
}

