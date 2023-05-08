namespace VSDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.input_display = new System.Windows.Forms.TextBox();
            this.btn_equals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_ob = new System.Windows.Forms.Button();
            this.btn_cb = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_rty = new System.Windows.Forms.Button();
            this.btn_rt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 23);
            this.textBox2.TabIndex = 0;
            // 
            // input_display
            // 
            this.input_display.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_display.ForeColor = System.Drawing.Color.Black;
            this.input_display.Location = new System.Drawing.Point(347, 90);
            this.input_display.Name = "input_display";
            this.input_display.Size = new System.Drawing.Size(350, 32);
            this.input_display.TabIndex = 0;
            this.input_display.TextChanged += new System.EventHandler(this.input_display_TextChanged);
            // 
            // btn_equals
            // 
            this.btn_equals.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_equals.Location = new System.Drawing.Point(523, 397);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(156, 43);
            this.btn_equals.TabIndex = 1;
            this.btn_equals.Text = "=";
            this.btn_equals.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_plus.Location = new System.Drawing.Point(361, 348);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 43);
            this.btn_plus.TabIndex = 2;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sub.Location = new System.Drawing.Point(442, 348);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 43);
            this.btn_sub.TabIndex = 3;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_mul.Location = new System.Drawing.Point(442, 397);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(75, 43);
            this.btn_mul.TabIndex = 4;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_div.Location = new System.Drawing.Point(361, 397);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 43);
            this.btn_div.TabIndex = 5;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_ob
            // 
            this.btn_ob.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ob.Location = new System.Drawing.Point(523, 201);
            this.btn_ob.Name = "btn_ob";
            this.btn_ob.Size = new System.Drawing.Size(75, 43);
            this.btn_ob.TabIndex = 6;
            this.btn_ob.Text = "(";
            this.btn_ob.UseVisualStyleBackColor = true;
            this.btn_ob.Click += new System.EventHandler(this.btn_ob_Click);
            // 
            // btn_cb
            // 
            this.btn_cb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cb.Location = new System.Drawing.Point(604, 201);
            this.btn_cb.Name = "btn_cb";
            this.btn_cb.Size = new System.Drawing.Size(75, 43);
            this.btn_cb.TabIndex = 7;
            this.btn_cb.Text = ")";
            this.btn_cb.UseVisualStyleBackColor = true;
            this.btn_cb.Click += new System.EventHandler(this.btn_cb_Click);
            // 
            // btn_ce
            // 
            this.btn_ce.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ce.Location = new System.Drawing.Point(361, 150);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(75, 43);
            this.btn_ce.TabIndex = 8;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = true;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(511, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(442, 150);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 43);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_0.Location = new System.Drawing.Point(361, 250);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 43);
            this.btn_0.TabIndex = 11;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_1.Location = new System.Drawing.Point(442, 250);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 43);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(523, 250);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 43);
            this.btn_2.TabIndex = 13;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_3.Location = new System.Drawing.Point(604, 250);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 43);
            this.btn_3.TabIndex = 14;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_4.Location = new System.Drawing.Point(361, 299);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 43);
            this.btn_4.TabIndex = 15;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_5.Location = new System.Drawing.Point(442, 299);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 43);
            this.btn_5.TabIndex = 16;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_6.Location = new System.Drawing.Point(523, 299);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 43);
            this.btn_6.TabIndex = 17;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_9.Location = new System.Drawing.Point(604, 348);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 43);
            this.btn_9.TabIndex = 18;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_8.Location = new System.Drawing.Point(523, 348);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 43);
            this.btn_8.TabIndex = 19;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_7.Location = new System.Drawing.Point(604, 299);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 43);
            this.btn_7.TabIndex = 20;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_rty
            // 
            this.btn_rty.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rty.Location = new System.Drawing.Point(442, 201);
            this.btn_rty.Name = "btn_rty";
            this.btn_rty.Size = new System.Drawing.Size(75, 43);
            this.btn_rty.TabIndex = 21;
            this.btn_rty.Text = "𝑥ʸ";
            this.btn_rty.UseVisualStyleBackColor = true;
            this.btn_rty.Click += new System.EventHandler(this.btn_rty_Click);
            // 
            // btn_rt
            // 
            this.btn_rt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rt.Location = new System.Drawing.Point(361, 201);
            this.btn_rt.Name = "btn_rt";
            this.btn_rt.Size = new System.Drawing.Size(75, 43);
            this.btn_rt.TabIndex = 22;
            this.btn_rt.Text = "^";
            this.btn_rt.UseVisualStyleBackColor = true;
            this.btn_rt.Click += new System.EventHandler(this.btn_rt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1030, 602);
            this.Controls.Add(this.btn_rt);
            this.Controls.Add(this.btn_rty);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_cb);
            this.Controls.Add(this.btn_ob);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.input_display);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox input_display;
        private Button btn_equals;
        private Label label1;
        private Button btn_plus;
        private Button btn_sub;
        private Button btn_mul;
        private Button btn_div;
        private Button btn_ob;
        private Button btn_cb;
        private Button btn_ce;
        private Button button1;
        private Button btn_back;
        private Button btn_0;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_rty;
        private Button btn_rt;
    }
}