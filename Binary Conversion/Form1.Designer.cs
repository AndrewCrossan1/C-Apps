
namespace Binary_Conversion
{
    partial class frmBinaryConversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBinaryConversion));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBinNum = new System.Windows.Forms.Label();
            this.lblRealNum = new System.Windows.Forms.Label();
            this.txtRealNum = new System.Windows.Forms.TextBox();
            this.lblWorking = new System.Windows.Forms.Label();
            this.picBinary = new System.Windows.Forms.PictureBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.textBinNum = new System.Windows.Forms.TextBox();
            this.box128 = new System.Windows.Forms.TextBox();
            this.box32 = new System.Windows.Forms.TextBox();
            this.box16 = new System.Windows.Forms.TextBox();
            this.box8 = new System.Windows.Forms.TextBox();
            this.box4 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.box1 = new System.Windows.Forms.TextBox();
            this.box64 = new System.Windows.Forms.TextBox();
            this.num128 = new System.Windows.Forms.TextBox();
            this.num64 = new System.Windows.Forms.TextBox();
            this.num32 = new System.Windows.Forms.TextBox();
            this.num16 = new System.Windows.Forms.TextBox();
            this.num8 = new System.Windows.Forms.TextBox();
            this.num4 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBinary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Binary Conversion";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 46);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(179, 26);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Enter 8-bit binary number below and \r\nclick convert";
            // 
            // lblBinNum
            // 
            this.lblBinNum.AutoSize = true;
            this.lblBinNum.Location = new System.Drawing.Point(14, 93);
            this.lblBinNum.Name = "lblBinNum";
            this.lblBinNum.Size = new System.Drawing.Size(79, 13);
            this.lblBinNum.TabIndex = 2;
            this.lblBinNum.Text = "Binary Number:";
            // 
            // lblRealNum
            // 
            this.lblRealNum.AutoSize = true;
            this.lblRealNum.Location = new System.Drawing.Point(14, 125);
            this.lblRealNum.Name = "lblRealNum";
            this.lblRealNum.Size = new System.Drawing.Size(72, 13);
            this.lblRealNum.TabIndex = 3;
            this.lblRealNum.Text = "Real Number:";
            // 
            // txtRealNum
            // 
            this.txtRealNum.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtRealNum.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtRealNum.Location = new System.Drawing.Point(107, 122);
            this.txtRealNum.Name = "txtRealNum";
            this.txtRealNum.ReadOnly = true;
            this.txtRealNum.Size = new System.Drawing.Size(173, 20);
            this.txtRealNum.TabIndex = 2;
            // 
            // lblWorking
            // 
            this.lblWorking.AutoSize = true;
            this.lblWorking.Location = new System.Drawing.Point(17, 157);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(50, 13);
            this.lblWorking.TabIndex = 7;
            this.lblWorking.Text = "Working:";
            // 
            // picBinary
            // 
            this.picBinary.Image = ((System.Drawing.Image)(resources.GetObject("picBinary.Image")));
            this.picBinary.Location = new System.Drawing.Point(198, 9);
            this.picBinary.Name = "picBinary";
            this.picBinary.Size = new System.Drawing.Size(80, 63);
            this.picBinary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBinary.TabIndex = 8;
            this.picBinary.TabStop = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(17, 247);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(263, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textBinNum
            // 
            this.textBinNum.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBinNum.ForeColor = System.Drawing.Color.LawnGreen;
            this.textBinNum.Location = new System.Drawing.Point(107, 90);
            this.textBinNum.Name = "textBinNum";
            this.textBinNum.Size = new System.Drawing.Size(171, 20);
            this.textBinNum.TabIndex = 1;
            // 
            // box128
            // 
            this.box128.BackColor = System.Drawing.Color.MidnightBlue;
            this.box128.ForeColor = System.Drawing.Color.LawnGreen;
            this.box128.Location = new System.Drawing.Point(20, 185);
            this.box128.Name = "box128";
            this.box128.ReadOnly = true;
            this.box128.Size = new System.Drawing.Size(27, 20);
            this.box128.TabIndex = 11;
            this.box128.Text = "128";
            this.box128.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box128.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // box32
            // 
            this.box32.BackColor = System.Drawing.Color.MidnightBlue;
            this.box32.ForeColor = System.Drawing.Color.LawnGreen;
            this.box32.Location = new System.Drawing.Point(86, 185);
            this.box32.Name = "box32";
            this.box32.ReadOnly = true;
            this.box32.Size = new System.Drawing.Size(27, 20);
            this.box32.TabIndex = 13;
            this.box32.Text = "32";
            this.box32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box16
            // 
            this.box16.BackColor = System.Drawing.Color.MidnightBlue;
            this.box16.ForeColor = System.Drawing.Color.LawnGreen;
            this.box16.Location = new System.Drawing.Point(119, 185);
            this.box16.Name = "box16";
            this.box16.ReadOnly = true;
            this.box16.Size = new System.Drawing.Size(27, 20);
            this.box16.TabIndex = 14;
            this.box16.Text = "16";
            this.box16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box8
            // 
            this.box8.BackColor = System.Drawing.Color.MidnightBlue;
            this.box8.ForeColor = System.Drawing.Color.LawnGreen;
            this.box8.Location = new System.Drawing.Point(152, 185);
            this.box8.Name = "box8";
            this.box8.ReadOnly = true;
            this.box8.Size = new System.Drawing.Size(27, 20);
            this.box8.TabIndex = 15;
            this.box8.Text = "8";
            this.box8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box4
            // 
            this.box4.BackColor = System.Drawing.Color.MidnightBlue;
            this.box4.ForeColor = System.Drawing.Color.LawnGreen;
            this.box4.Location = new System.Drawing.Point(185, 185);
            this.box4.Name = "box4";
            this.box4.ReadOnly = true;
            this.box4.Size = new System.Drawing.Size(27, 20);
            this.box4.TabIndex = 16;
            this.box4.Text = "4";
            this.box4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.MidnightBlue;
            this.box2.ForeColor = System.Drawing.Color.LawnGreen;
            this.box2.Location = new System.Drawing.Point(218, 185);
            this.box2.Name = "box2";
            this.box2.ReadOnly = true;
            this.box2.Size = new System.Drawing.Size(27, 20);
            this.box2.TabIndex = 17;
            this.box2.Text = "2";
            this.box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.MidnightBlue;
            this.box1.ForeColor = System.Drawing.Color.LawnGreen;
            this.box1.Location = new System.Drawing.Point(251, 185);
            this.box1.Name = "box1";
            this.box1.ReadOnly = true;
            this.box1.Size = new System.Drawing.Size(27, 20);
            this.box1.TabIndex = 18;
            this.box1.Text = "1";
            this.box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box64
            // 
            this.box64.BackColor = System.Drawing.Color.MidnightBlue;
            this.box64.ForeColor = System.Drawing.Color.LawnGreen;
            this.box64.Location = new System.Drawing.Point(53, 185);
            this.box64.Name = "box64";
            this.box64.ReadOnly = true;
            this.box64.Size = new System.Drawing.Size(27, 20);
            this.box64.TabIndex = 19;
            this.box64.Text = "64";
            this.box64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num128
            // 
            this.num128.BackColor = System.Drawing.Color.MidnightBlue;
            this.num128.ForeColor = System.Drawing.Color.LawnGreen;
            this.num128.Location = new System.Drawing.Point(20, 221);
            this.num128.Name = "num128";
            this.num128.ReadOnly = true;
            this.num128.Size = new System.Drawing.Size(27, 20);
            this.num128.TabIndex = 20;
            this.num128.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num64
            // 
            this.num64.BackColor = System.Drawing.Color.MidnightBlue;
            this.num64.ForeColor = System.Drawing.Color.LawnGreen;
            this.num64.Location = new System.Drawing.Point(53, 221);
            this.num64.Name = "num64";
            this.num64.ReadOnly = true;
            this.num64.Size = new System.Drawing.Size(27, 20);
            this.num64.TabIndex = 21;
            this.num64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num32
            // 
            this.num32.BackColor = System.Drawing.Color.MidnightBlue;
            this.num32.ForeColor = System.Drawing.Color.LawnGreen;
            this.num32.Location = new System.Drawing.Point(86, 221);
            this.num32.Name = "num32";
            this.num32.ReadOnly = true;
            this.num32.Size = new System.Drawing.Size(27, 20);
            this.num32.TabIndex = 22;
            this.num32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num16
            // 
            this.num16.BackColor = System.Drawing.Color.MidnightBlue;
            this.num16.ForeColor = System.Drawing.Color.LawnGreen;
            this.num16.Location = new System.Drawing.Point(119, 221);
            this.num16.Name = "num16";
            this.num16.ReadOnly = true;
            this.num16.Size = new System.Drawing.Size(27, 20);
            this.num16.TabIndex = 23;
            this.num16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.MidnightBlue;
            this.num8.ForeColor = System.Drawing.Color.LawnGreen;
            this.num8.Location = new System.Drawing.Point(152, 221);
            this.num8.Name = "num8";
            this.num8.ReadOnly = true;
            this.num8.Size = new System.Drawing.Size(27, 20);
            this.num8.TabIndex = 24;
            this.num8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.MidnightBlue;
            this.num4.ForeColor = System.Drawing.Color.LawnGreen;
            this.num4.Location = new System.Drawing.Point(185, 221);
            this.num4.Name = "num4";
            this.num4.ReadOnly = true;
            this.num4.Size = new System.Drawing.Size(27, 20);
            this.num4.TabIndex = 25;
            this.num4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.MidnightBlue;
            this.num2.ForeColor = System.Drawing.Color.LawnGreen;
            this.num2.Location = new System.Drawing.Point(218, 221);
            this.num2.Name = "num2";
            this.num2.ReadOnly = true;
            this.num2.Size = new System.Drawing.Size(27, 20);
            this.num2.TabIndex = 26;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.MidnightBlue;
            this.num1.ForeColor = System.Drawing.Color.LawnGreen;
            this.num1.Location = new System.Drawing.Point(251, 221);
            this.num1.Name = "num1";
            this.num1.ReadOnly = true;
            this.num1.Size = new System.Drawing.Size(27, 20);
            this.num1.TabIndex = 27;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmBinaryConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 282);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num16);
            this.Controls.Add(this.num32);
            this.Controls.Add(this.num64);
            this.Controls.Add(this.num128);
            this.Controls.Add(this.box64);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box16);
            this.Controls.Add(this.box32);
            this.Controls.Add(this.box128);
            this.Controls.Add(this.textBinNum);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.picBinary);
            this.Controls.Add(this.lblWorking);
            this.Controls.Add(this.txtRealNum);
            this.Controls.Add(this.lblRealNum);
            this.Controls.Add(this.lblBinNum);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBinaryConversion";
            this.Text = "Binary Conversion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBinary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBinNum;
        private System.Windows.Forms.Label lblRealNum;
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.PictureBox picBinary;
        private System.Windows.Forms.Button btnConvert;
        public System.Windows.Forms.TextBox textBinNum;
        public System.Windows.Forms.TextBox txtRealNum;
        private System.Windows.Forms.TextBox box128;
        private System.Windows.Forms.TextBox box32;
        private System.Windows.Forms.TextBox box16;
        private System.Windows.Forms.TextBox box8;
        private System.Windows.Forms.TextBox box4;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box64;
        private System.Windows.Forms.TextBox num128;
        private System.Windows.Forms.TextBox num64;
        private System.Windows.Forms.TextBox num32;
        private System.Windows.Forms.TextBox num16;
        private System.Windows.Forms.TextBox num8;
        private System.Windows.Forms.TextBox num4;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num1;
    }
}

