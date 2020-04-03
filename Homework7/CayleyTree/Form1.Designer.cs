namespace CayleyTree
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
            this.pnlDrawArea = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.cmbDepth = new System.Windows.Forms.ComboBox();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.tkbRightPer = new System.Windows.Forms.TrackBar();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtRightPer = new System.Windows.Forms.Label();
            this.lblRightPerValue = new System.Windows.Forms.Label();
            this.txtLeftPer = new System.Windows.Forms.Label();
            this.lblRightTh = new System.Windows.Forms.Label();
            this.lblLeftTh = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblLeftPerValue = new System.Windows.Forms.Label();
            this.lblRightThValue = new System.Windows.Forms.Label();
            this.lblLeftThValue = new System.Windows.Forms.Label();
            this.tkbLeftPer = new System.Windows.Forms.TrackBar();
            this.tkbRightTh = new System.Windows.Forms.TrackBar();
            this.tkbLeftTh = new System.Windows.Forms.TrackBar();
            this.pnlColorArea = new System.Windows.Forms.Panel();
            this.rdbOrange = new System.Windows.Forms.RadioButton();
            this.rdbYellow = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRightPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLeftPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRightTh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLeftTh)).BeginInit();
            this.pnlColorArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawArea
            // 
            this.pnlDrawArea.Location = new System.Drawing.Point(1, 1);
            this.pnlDrawArea.Name = "pnlDrawArea";
            this.pnlDrawArea.Size = new System.Drawing.Size(485, 437);
            this.pnlDrawArea.TabIndex = 0;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(616, 402);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(91, 36);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "绘制";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // cmbDepth
            // 
            this.cmbDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepth.FormattingEnabled = true;
            this.cmbDepth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbDepth.Location = new System.Drawing.Point(616, 24);
            this.cmbDepth.Name = "cmbDepth";
            this.cmbDepth.Size = new System.Drawing.Size(137, 23);
            this.cmbDepth.TabIndex = 2;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(529, 27);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(67, 15);
            this.lblDepth.TabIndex = 3;
            this.lblDepth.Text = "递归深度";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(529, 72);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(67, 15);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "主干长度";
            // 
            // tkbRightPer
            // 
            this.tkbRightPer.Location = new System.Drawing.Point(606, 114);
            this.tkbRightPer.Maximum = 100;
            this.tkbRightPer.Name = "tkbRightPer";
            this.tkbRightPer.Size = new System.Drawing.Size(134, 56);
            this.tkbRightPer.TabIndex = 5;
            this.tkbRightPer.Value = 60;
            this.tkbRightPer.Scroll += new System.EventHandler(this.tkbRightPer_Scroll);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(616, 69);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(137, 25);
            this.txtLength.TabIndex = 6;
            // 
            // txtRightPer
            // 
            this.txtRightPer.AutoSize = true;
            this.txtRightPer.Location = new System.Drawing.Point(499, 121);
            this.txtRightPer.Name = "txtRightPer";
            this.txtRightPer.Size = new System.Drawing.Size(97, 15);
            this.txtRightPer.TabIndex = 7;
            this.txtRightPer.Text = "右分支长度比";
            // 
            // lblRightPerValue
            // 
            this.lblRightPerValue.AutoSize = true;
            this.lblRightPerValue.Location = new System.Drawing.Point(746, 118);
            this.lblRightPerValue.Name = "lblRightPerValue";
            this.lblRightPerValue.Size = new System.Drawing.Size(31, 15);
            this.lblRightPerValue.TabIndex = 8;
            this.lblRightPerValue.Text = "0.6";
            // 
            // txtLeftPer
            // 
            this.txtLeftPer.AutoSize = true;
            this.txtLeftPer.Location = new System.Drawing.Point(499, 168);
            this.txtLeftPer.Name = "txtLeftPer";
            this.txtLeftPer.Size = new System.Drawing.Size(97, 15);
            this.txtLeftPer.TabIndex = 9;
            this.txtLeftPer.Text = "左分支长度比";
            // 
            // lblRightTh
            // 
            this.lblRightTh.AutoSize = true;
            this.lblRightTh.Location = new System.Drawing.Point(514, 215);
            this.lblRightTh.Name = "lblRightTh";
            this.lblRightTh.Size = new System.Drawing.Size(82, 15);
            this.lblRightTh.TabIndex = 10;
            this.lblRightTh.Text = "右分支角度";
            // 
            // lblLeftTh
            // 
            this.lblLeftTh.AutoSize = true;
            this.lblLeftTh.Location = new System.Drawing.Point(514, 262);
            this.lblLeftTh.Name = "lblLeftTh";
            this.lblLeftTh.Size = new System.Drawing.Size(82, 15);
            this.lblLeftTh.TabIndex = 11;
            this.lblLeftTh.Text = "左分支角度";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(514, 350);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(67, 15);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "画笔颜色";
            // 
            // lblLeftPerValue
            // 
            this.lblLeftPerValue.AutoSize = true;
            this.lblLeftPerValue.Location = new System.Drawing.Point(746, 165);
            this.lblLeftPerValue.Name = "lblLeftPerValue";
            this.lblLeftPerValue.Size = new System.Drawing.Size(31, 15);
            this.lblLeftPerValue.TabIndex = 13;
            this.lblLeftPerValue.Text = "0.6";
            // 
            // lblRightThValue
            // 
            this.lblRightThValue.AutoSize = true;
            this.lblRightThValue.Location = new System.Drawing.Point(746, 214);
            this.lblRightThValue.Name = "lblRightThValue";
            this.lblRightThValue.Size = new System.Drawing.Size(38, 15);
            this.lblRightThValue.TabIndex = 14;
            this.lblRightThValue.Text = "30°";
            // 
            // lblLeftThValue
            // 
            this.lblLeftThValue.AutoSize = true;
            this.lblLeftThValue.Location = new System.Drawing.Point(746, 265);
            this.lblLeftThValue.Name = "lblLeftThValue";
            this.lblLeftThValue.Size = new System.Drawing.Size(38, 15);
            this.lblLeftThValue.TabIndex = 15;
            this.lblLeftThValue.Text = "30°";
            // 
            // tkbLeftPer
            // 
            this.tkbLeftPer.Location = new System.Drawing.Point(606, 161);
            this.tkbLeftPer.Maximum = 100;
            this.tkbLeftPer.Name = "tkbLeftPer";
            this.tkbLeftPer.Size = new System.Drawing.Size(134, 56);
            this.tkbLeftPer.TabIndex = 16;
            this.tkbLeftPer.Value = 60;
            this.tkbLeftPer.Scroll += new System.EventHandler(this.tkbLeftPer_Scroll);
            // 
            // tkbRightTh
            // 
            this.tkbRightTh.Location = new System.Drawing.Point(606, 208);
            this.tkbRightTh.Maximum = 90;
            this.tkbRightTh.Name = "tkbRightTh";
            this.tkbRightTh.Size = new System.Drawing.Size(134, 56);
            this.tkbRightTh.TabIndex = 17;
            this.tkbRightTh.Value = 30;
            this.tkbRightTh.Scroll += new System.EventHandler(this.tkbRightTh_Scroll);
            // 
            // tkbLeftTh
            // 
            this.tkbLeftTh.Location = new System.Drawing.Point(606, 261);
            this.tkbLeftTh.Maximum = 90;
            this.tkbLeftTh.Name = "tkbLeftTh";
            this.tkbLeftTh.Size = new System.Drawing.Size(134, 56);
            this.tkbLeftTh.TabIndex = 18;
            this.tkbLeftTh.Value = 30;
            this.tkbLeftTh.Scroll += new System.EventHandler(this.tkbLeftTh_Scroll);
            // 
            // pnlColorArea
            // 
            this.pnlColorArea.Controls.Add(this.rdbOrange);
            this.pnlColorArea.Controls.Add(this.rdbYellow);
            this.pnlColorArea.Controls.Add(this.rdbGreen);
            this.pnlColorArea.Controls.Add(this.rdbBlue);
            this.pnlColorArea.Controls.Add(this.rdbBlack);
            this.pnlColorArea.Controls.Add(this.rdbRed);
            this.pnlColorArea.Location = new System.Drawing.Point(597, 312);
            this.pnlColorArea.Name = "pnlColorArea";
            this.pnlColorArea.Size = new System.Drawing.Size(191, 84);
            this.pnlColorArea.TabIndex = 19;
            // 
            // rdbOrange
            // 
            this.rdbOrange.AutoSize = true;
            this.rdbOrange.Location = new System.Drawing.Point(130, 53);
            this.rdbOrange.Name = "rdbOrange";
            this.rdbOrange.Size = new System.Drawing.Size(58, 19);
            this.rdbOrange.TabIndex = 5;
            this.rdbOrange.Text = "橘色";
            this.rdbOrange.UseVisualStyleBackColor = true;
            // 
            // rdbYellow
            // 
            this.rdbYellow.AutoSize = true;
            this.rdbYellow.Location = new System.Drawing.Point(67, 53);
            this.rdbYellow.Name = "rdbYellow";
            this.rdbYellow.Size = new System.Drawing.Size(58, 19);
            this.rdbYellow.TabIndex = 4;
            this.rdbYellow.Text = "黄色";
            this.rdbYellow.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(3, 53);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(58, 19);
            this.rdbGreen.TabIndex = 3;
            this.rdbGreen.Text = "绿色";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Checked = true;
            this.rdbBlue.Location = new System.Drawing.Point(131, 15);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(58, 19);
            this.rdbBlue.TabIndex = 2;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "蓝色";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(67, 15);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(58, 19);
            this.rdbBlack.TabIndex = 1;
            this.rdbBlack.Text = "黑色";
            this.rdbBlack.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(3, 15);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(58, 19);
            this.rdbRed.TabIndex = 0;
            this.rdbRed.Text = "红色";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlColorArea);
            this.Controls.Add(this.tkbLeftTh);
            this.Controls.Add(this.tkbRightTh);
            this.Controls.Add(this.tkbLeftPer);
            this.Controls.Add(this.lblLeftThValue);
            this.Controls.Add(this.lblRightThValue);
            this.Controls.Add(this.lblLeftPerValue);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblLeftTh);
            this.Controls.Add(this.lblRightTh);
            this.Controls.Add(this.txtLeftPer);
            this.Controls.Add(this.lblRightPerValue);
            this.Controls.Add(this.txtRightPer);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.tkbRightPer);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.cmbDepth);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pnlDrawArea);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbRightPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLeftPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRightTh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLeftTh)).EndInit();
            this.pnlColorArea.ResumeLayout(false);
            this.pnlColorArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawArea;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ComboBox cmbDepth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TrackBar tkbRightPer;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label txtRightPer;
        private System.Windows.Forms.Label lblRightPerValue;
        private System.Windows.Forms.Label txtLeftPer;
        private System.Windows.Forms.Label lblRightTh;
        private System.Windows.Forms.Label lblLeftTh;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblLeftPerValue;
        private System.Windows.Forms.Label lblRightThValue;
        private System.Windows.Forms.Label lblLeftThValue;
        private System.Windows.Forms.TrackBar tkbLeftPer;
        private System.Windows.Forms.TrackBar tkbRightTh;
        private System.Windows.Forms.TrackBar tkbLeftTh;
        private System.Windows.Forms.Panel pnlColorArea;
        private System.Windows.Forms.RadioButton rdbOrange;
        private System.Windows.Forms.RadioButton rdbYellow;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbRed;
    }
}

