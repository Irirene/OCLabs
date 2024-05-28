namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.button11 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.button14 = new System.Windows.Forms.Button();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.button15 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(29, 48);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(371, 369);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(429, 48);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(363, 369);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(29, 452);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 436);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "ЧБ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 432);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Цветовой канал";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(317, 436);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sepia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(209, 468);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Медианное размытие";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(99, 489);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(99, 572);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown3.TabIndex = 10;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 517);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 31);
            this.button5.TabIndex = 11;
            this.button5.Text = "Применить яркость";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Яркость: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Контраст: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 606);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Применить контраст";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(465, 436);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 26);
            this.button7.TabIndex = 15;
            this.button7.Text = "Load Image 2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(465, 468);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 28);
            this.button8.TabIndex = 16;
            this.button8.Text = "Дополнение";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(465, 502);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(116, 28);
            this.button9.TabIndex = 17;
            this.button9.Text = "Исключение";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(465, 534);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(116, 28);
            this.button10.TabIndex = 18;
            this.button10.Text = "Пересечение";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Тон:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(729, 446);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown4.TabIndex = 20;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Насыщенность:";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(729, 478);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown5.TabIndex = 23;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(625, 539);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(167, 23);
            this.button11.TabIndex = 24;
            this.button11.Text = "Применить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Значение:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(729, 508);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown6.TabIndex = 26;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(820, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 22);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(851, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 22);
            this.textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(882, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(26, 22);
            this.textBox3.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(820, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(25, 22);
            this.textBox4.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(851, 99);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(25, 22);
            this.textBox5.TabIndex = 31;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(882, 99);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(25, 22);
            this.textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(820, 127);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(25, 22);
            this.textBox7.TabIndex = 33;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(851, 127);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(25, 22);
            this.textBox8.TabIndex = 34;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(882, 127);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(25, 22);
            this.textBox9.TabIndex = 35;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(807, 155);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(117, 23);
            this.button12.TabIndex = 36;
            this.button12.Text = "Применить";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(804, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Оконный фильтр:";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(937, 57);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(126, 26);
            this.button13.TabIndex = 38;
            this.button13.Text = "Load Image 2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(937, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Яркость:";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(1007, 84);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown7.TabIndex = 40;
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(937, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Контраст:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(1007, 109);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown8.TabIndex = 42;
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.numericUpDown8_ValueChanged);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(940, 137);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(123, 23);
            this.button14.TabIndex = 43;
            this.button14.Text = "Применить";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(966, 218);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown9.TabIndex = 44;
            this.numericUpDown9.ValueChanged += new System.EventHandler(this.numericUpDown9_ValueChanged);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(814, 246);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(204, 23);
            this.button15.TabIndex = 45;
            this.button15.Text = "Применить";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(817, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "Пороговое значение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 686);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.numericUpDown9);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.numericUpDown8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label10;
    }
}

