namespace Рисунок_3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButtonSqrt = new System.Windows.Forms.RadioButton();
            this.radioButtonHyperbola = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(686, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Кнопка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonSqrt
            // 
            this.radioButtonSqrt.AutoSize = true;
            this.radioButtonSqrt.Location = new System.Drawing.Point(686, 116);
            this.radioButtonSqrt.Name = "radioButtonSqrt";
            this.radioButtonSqrt.Size = new System.Drawing.Size(75, 20);
            this.radioButtonSqrt.TabIndex = 5;
            this.radioButtonSqrt.TabStop = true;
            this.radioButtonSqrt.Text = "Корень";
            this.radioButtonSqrt.UseVisualStyleBackColor = true;
            this.radioButtonSqrt.CheckedChanged += new System.EventHandler(this.radioButtonSqrt_CheckedChanged);
            // 
            // radioButtonHyperbola
            // 
            this.radioButtonHyperbola.AutoSize = true;
            this.radioButtonHyperbola.Location = new System.Drawing.Point(685, 152);
            this.radioButtonHyperbola.Name = "radioButtonHyperbola";
            this.radioButtonHyperbola.Size = new System.Drawing.Size(99, 20);
            this.radioButtonHyperbola.TabIndex = 6;
            this.radioButtonHyperbola.TabStop = true;
            this.radioButtonHyperbola.Text = "Гипербола";
            this.radioButtonHyperbola.UseVisualStyleBackColor = true;
            this.radioButtonHyperbola.CheckedChanged += new System.EventHandler(this.radioButtonHyperbola_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonHyperbola);
            this.Controls.Add(this.radioButtonSqrt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButtonSqrt;
        private System.Windows.Forms.RadioButton radioButtonHyperbola;
    }
}

