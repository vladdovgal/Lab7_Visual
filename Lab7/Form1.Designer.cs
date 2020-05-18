namespace Lab7
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
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colourbtn1 = new System.Windows.Forms.Button();
            this.colourbox1 = new System.Windows.Forms.TextBox();
            this.colourbox2 = new System.Windows.Forms.TextBox();
            this.colourbtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Build rectangle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height";
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // colourbtn1
            // 
            this.colourbtn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colourbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colourbtn1.Location = new System.Drawing.Point(251, 26);
            this.colourbtn1.Name = "colourbtn1";
            this.colourbtn1.Size = new System.Drawing.Size(84, 32);
            this.colourbtn1.TabIndex = 8;
            this.colourbtn1.Text = "Colour 1";
            this.colourbtn1.UseVisualStyleBackColor = true;
            this.colourbtn1.Click += new System.EventHandler(this.colourbtn1_Click);
            // 
            // colourbox1
            // 
            this.colourbox1.Location = new System.Drawing.Point(373, 26);
            this.colourbox1.Name = "colourbox1";
            this.colourbox1.Size = new System.Drawing.Size(100, 22);
            this.colourbox1.TabIndex = 9;
            // 
            // colourbox2
            // 
            this.colourbox2.Location = new System.Drawing.Point(373, 64);
            this.colourbox2.Name = "colourbox2";
            this.colourbox2.Size = new System.Drawing.Size(100, 22);
            this.colourbox2.TabIndex = 10;
            // 
            // colourbtn2
            // 
            this.colourbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colourbtn2.Location = new System.Drawing.Point(251, 64);
            this.colourbtn2.Name = "colourbtn2";
            this.colourbtn2.Size = new System.Drawing.Size(84, 34);
            this.colourbtn2.TabIndex = 11;
            this.colourbtn2.Text = "Colour 2";
            this.colourbtn2.UseVisualStyleBackColor = true;
            this.colourbtn2.Click += new System.EventHandler(this.colourbtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colourbtn1);
            this.Controls.Add(this.colourbtn2);
            this.Controls.Add(this.colourbox1);
            this.Controls.Add(this.colourbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button colourbtn1;
        private System.Windows.Forms.Button colourbtn2;
        private System.Windows.Forms.TextBox colourbox1;
        private System.Windows.Forms.TextBox colourbox2;

    }
}

