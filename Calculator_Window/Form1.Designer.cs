namespace Calculator_Window
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
            this.title = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.op = new System.Windows.Forms.ComboBox();
            this.calculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(356, 55);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(173, 29);
            this.title.TabIndex = 0;
            this.title.Text = "Calculator";
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num1.Location = new System.Drawing.Point(265, 114);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 31);
            this.num1.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num2.Location = new System.Drawing.Point(519, 114);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 31);
            this.num2.TabIndex = 2;
            // 
            // op
            // 
            this.op.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.op.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.op.FormattingEnabled = true;
            this.op.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.op.Location = new System.Drawing.Point(380, 114);
            this.op.MaxDropDownItems = 4;
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(121, 29);
            this.op.TabIndex = 3;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calculate.Location = new System.Drawing.Point(380, 172);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(121, 32);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.Location = new System.Drawing.Point(389, 226);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 21);
            this.result.TabIndex = 5;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(380, 272);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 21);
            this.error.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.op);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.ComboBox op;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label error;
    }
}

