namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(14, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 68);
            this.textBox1.TabIndex = 0;
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.one.Location = new System.Drawing.Point(12, 90);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(60, 60);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.two.Location = new System.Drawing.Point(80, 90);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(60, 60);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.three.Location = new System.Drawing.Point(146, 90);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(60, 60);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plus.Location = new System.Drawing.Point(212, 90);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 60);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.four.Location = new System.Drawing.Point(14, 156);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(60, 60);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.five.Location = new System.Drawing.Point(80, 156);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(60, 60);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.six.Location = new System.Drawing.Point(146, 156);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(60, 60);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sub.Location = new System.Drawing.Point(212, 156);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(60, 60);
            this.sub.TabIndex = 8;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.seven.Location = new System.Drawing.Point(14, 222);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(60, 60);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eight.Location = new System.Drawing.Point(80, 222);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(60, 60);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nine.Location = new System.Drawing.Point(146, 222);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(60, 60);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mul.Location = new System.Drawing.Point(212, 222);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(60, 60);
            this.mul.TabIndex = 12;
            this.mul.Text = "x";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.point.Location = new System.Drawing.Point(12, 288);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(60, 60);
            this.point.TabIndex = 13;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zero.Location = new System.Drawing.Point(78, 288);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(60, 60);
            this.zero.TabIndex = 14;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equal.Location = new System.Drawing.Point(144, 288);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(60, 60);
            this.equal.TabIndex = 15;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.div.Location = new System.Drawing.Point(210, 288);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(60, 60);
            this.div.TabIndex = 16;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // Mod
            // 
            this.Mod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mod.Location = new System.Drawing.Point(14, 354);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(60, 60);
            this.Mod.TabIndex = 17;
            this.Mod.Text = "Mod";
            this.Mod.UseVisualStyleBackColor = false;
            this.Mod.Click += new System.EventHandler(this.button1_Click);
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Power.Location = new System.Drawing.Point(78, 354);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(60, 60);
            this.Power.TabIndex = 18;
            this.Power.Text = "Pow";
            this.Power.UseVisualStyleBackColor = false;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.Location = new System.Drawing.Point(146, 354);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 60);
            this.clear.TabIndex = 19;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // i
            // 
            this.i.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.i.Location = new System.Drawing.Point(210, 354);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(60, 60);
            this.i.TabIndex = 20;
            this.i.Text = "i";
            this.i.UseVisualStyleBackColor = false;
            this.i.Click += new System.EventHandler(this.zz_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(284, 425);
            this.Controls.Add(this.i);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.div);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.point);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button i;
    }
}

