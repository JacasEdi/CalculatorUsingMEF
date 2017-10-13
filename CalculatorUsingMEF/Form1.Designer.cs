namespace CalculatorUsingMEF
{
    partial class Form1
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
            this.labelFirstNum = new System.Windows.Forms.Label();
            this.labelSecNum = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxFirstNum = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxSecNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstNum
            // 
            this.labelFirstNum.AutoSize = true;
            this.labelFirstNum.Location = new System.Drawing.Point(13, 13);
            this.labelFirstNum.Name = "labelFirstNum";
            this.labelFirstNum.Size = new System.Drawing.Size(100, 20);
            this.labelFirstNum.TabIndex = 0;
            this.labelFirstNum.Text = "First Number";
            this.labelFirstNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSecNum
            // 
            this.labelSecNum.AutoSize = true;
            this.labelSecNum.Location = new System.Drawing.Point(12, 49);
            this.labelSecNum.Name = "labelSecNum";
            this.labelSecNum.Size = new System.Drawing.Size(124, 20);
            this.labelSecNum.TabIndex = 1;
            this.labelSecNum.Text = "Second Number";
            this.labelSecNum.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 83);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 20);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Result";
            this.labelResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxFirstNum
            // 
            this.textBoxFirstNum.Location = new System.Drawing.Point(166, 13);
            this.textBoxFirstNum.Name = "textBoxFirstNum";
            this.textBoxFirstNum.Size = new System.Drawing.Size(100, 26);
            this.textBoxFirstNum.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(166, 83);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 26);
            this.textBoxResult.TabIndex = 4;
            // 
            // textBoxSecNum
            // 
            this.textBoxSecNum.Location = new System.Drawing.Point(166, 49);
            this.textBoxSecNum.Name = "textBoxSecNum";
            this.textBoxSecNum.Size = new System.Drawing.Size(100, 26);
            this.textBoxSecNum.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(97, 149);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(85, 29);
            this.btnSubtract.TabIndex = 8;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(17, 184);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 29);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(97, 184);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(85, 29);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxSecNum);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxFirstNum);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSecNum);
            this.Controls.Add(this.labelFirstNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstNum;
        private System.Windows.Forms.Label labelSecNum;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxFirstNum;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxSecNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
    }
}

