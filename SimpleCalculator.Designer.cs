namespace dzagar_SE3353_SimpleCalculator
{
    partial class SimpleCalculator
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
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.RPN = new System.Windows.Forms.Button();
            this.INFIX = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.decBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.Enabled = false;
            this.MainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextBox.Location = new System.Drawing.Point(29, 31);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(493, 81);
            this.MainTextBox.TabIndex = 0;
            // 
            // RPN
            // 
            this.RPN.Location = new System.Drawing.Point(571, 44);
            this.RPN.Name = "RPN";
            this.RPN.Size = new System.Drawing.Size(171, 59);
            this.RPN.TabIndex = 1;
            this.RPN.Text = "RPN";
            this.RPN.UseVisualStyleBackColor = true;
            this.RPN.Click += new System.EventHandler(this.RPN_Click);
            // 
            // INFIX
            // 
            this.INFIX.Location = new System.Drawing.Point(782, 44);
            this.INFIX.Name = "INFIX";
            this.INFIX.Size = new System.Drawing.Size(171, 59);
            this.INFIX.TabIndex = 2;
            this.INFIX.Text = "INFIX";
            this.INFIX.UseVisualStyleBackColor = true;
            this.INFIX.Click += new System.EventHandler(this.INFIX_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Location = new System.Drawing.Point(29, 470);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(225, 83);
            this.zeroBtn.TabIndex = 3;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Location = new System.Drawing.Point(29, 157);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(124, 83);
            this.oneBtn.TabIndex = 4;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Location = new System.Drawing.Point(214, 157);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(124, 83);
            this.twoBtn.TabIndex = 5;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Location = new System.Drawing.Point(398, 157);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(124, 83);
            this.threeBtn.TabIndex = 6;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Location = new System.Drawing.Point(29, 260);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(124, 83);
            this.fourBtn.TabIndex = 7;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Location = new System.Drawing.Point(214, 260);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(124, 83);
            this.fiveBtn.TabIndex = 8;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Location = new System.Drawing.Point(398, 260);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(124, 83);
            this.sixBtn.TabIndex = 9;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Location = new System.Drawing.Point(29, 366);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(124, 83);
            this.sevenBtn.TabIndex = 10;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Location = new System.Drawing.Point(214, 366);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(124, 83);
            this.eightBtn.TabIndex = 11;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Location = new System.Drawing.Point(398, 366);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(124, 83);
            this.nineBtn.TabIndex = 12;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // decBtn
            // 
            this.decBtn.Location = new System.Drawing.Point(297, 470);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(225, 83);
            this.decBtn.TabIndex = 13;
            this.decBtn.Text = ".";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(571, 157);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(171, 104);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(782, 157);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(171, 104);
            this.subBtn.TabIndex = 15;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Location = new System.Drawing.Point(571, 301);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(171, 104);
            this.multiplyBtn.TabIndex = 16;
            this.multiplyBtn.Text = "X";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(782, 301);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(171, 104);
            this.divBtn.TabIndex = 17;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // equalsBtn
            // 
            this.equalsBtn.Location = new System.Drawing.Point(571, 450);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(382, 103);
            this.equalsBtn.TabIndex = 18;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = true;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 602);
            this.Controls.Add(this.equalsBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.INFIX);
            this.Controls.Add(this.RPN);
            this.Controls.Add(this.MainTextBox);
            this.Name = "SimpleCalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.Button RPN;
        private System.Windows.Forms.Button INFIX;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button equalsBtn;
    }
}

